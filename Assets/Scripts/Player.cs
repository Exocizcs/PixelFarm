using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5;

    private new Rigidbody2D rigidbody;
    private Animator animator;
    private Vector3 direction;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>(); 
        animator = GetComponent<Animator>();  
    }

    private void Update() 
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        rigidbody.MovePosition(transform.position + (direction.normalized * speed * Time.deltaTime));

        UpdateAnimator();
    }
    private void UpdateAnimator()
    {
        if (direction != Vector3.zero)
        {
            animator.SetFloat("moveX", direction.x);
            animator.SetFloat("moveY", direction.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }
    
}