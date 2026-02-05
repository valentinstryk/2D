using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    [SerializeField] private float speed;
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    void Update()
    {
        float x =  Input.GetAxis("Horizontal");
        if (x < 0)
        {
            spriteRenderer.flipX = true;
            animator.SetFloat("Speed", Mathf.Abs(x));
        }
        else if (x > 0)
        {
            spriteRenderer.flipX = false;
            animator.SetFloat("Speed", Mathf.Abs(x));
        }

      
        
        float y =  Input.GetAxis("Vertical");
        if(y > 0)
        {
            animator.SetFloat("Speed", Mathf.Abs(y));
        }
        else if (y < 0)
        {
            animator.SetFloat("Speed", Mathf.Abs(y));
        }
        transform.position += new Vector3(x,y,0) * (speed * Time.deltaTime);
       
        
    }
}
