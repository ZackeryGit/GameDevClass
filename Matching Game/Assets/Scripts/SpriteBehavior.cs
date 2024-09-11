using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    // Start is called before the first frame update
    void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID colorId){
        rendererObj.color = colorId.value;
    }

}
