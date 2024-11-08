using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = ("Character Patterns/Character Move"))]
public class CharacterMove2d : CharacterPattern
{

    public UnityEvent doubleJumpEvent;

    public override void Move( CharacterController controller)
    {
        positionDirection.x = Input.GetAxis("Horizontal")* speed;

        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
            coyoteTimer = coyoteTime;

        } else {

            if (coyoteTimer > 0) {
                coyoteTimer -= Time.deltaTime;
            }

            if (jumpCount == 0 && coyoteTimer <= 0){
                jumpCount = 1;
            }

        }

        if (jumpCount < jumpCountMax && Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
            positionDirection.y = jumpForce;
            if (jumpCount != 0){
                doubleJumpEvent.Invoke();
            }
            jumpCount++;
            
        }
        
        positionDirection.y -= gravity * Time.deltaTime;
        
        //if (!Input.anyKey)
        //{
        //    positionDirection.x = 0f;
        //}
  

        // ChatGPT Code NOT MINE
        // Apply movement
        controller.Move(positionDirection * Time.deltaTime);

        // Freeze Z position by resetting it to a fixed value, e.g., starting position's Z.
        Vector3 fixedPosition = controller.transform.position;
        fixedPosition.z = 0; // Set to the desired Z value, like starting Z
        controller.transform.position = fixedPosition;
        
    }
}