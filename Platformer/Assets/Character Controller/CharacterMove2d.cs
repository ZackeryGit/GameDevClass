using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = ("Character Patterns/Character Move"))]
public class CharacterMove2d : CharacterPattern
{

    public UnityEvent doubleJumpEvent;

    public override void Move( CharacterController controller)
    {
        positionDirection.x = Input.GetAxis("Horizontal")*Speed;

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
            positionDirection.y = jumpForce;
            if (jumpCount != 0){
                doubleJumpEvent.Invoke();
            }
            jumpCount++;
            
        }
        
        positionDirection.y -= gravity;
        
        if (!Input.anyKey)
        {
            positionDirection.x = 0f;
        }
  
        controller.Move(positionDirection*Time.deltaTime);
    }
}