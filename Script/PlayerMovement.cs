using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Camera mainCamera;

    private Rigidbody rb;
    private Vector3 moveDirection;

    Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    
    private void Update()
    {
        // Input untuk pergerakan kiri/kanan
        float moveX = Input.GetAxisRaw("Horizontal");
        moveDirection = new Vector3(moveX, 0, 0).normalized;
    }

    private void FixedUpdate()
    {
        // Gerakkan karakter berdasarkan input
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, rb.velocity.y);
        //if(moveDirection.x > 0)
        //{
        //    animator.SetBool("MoveRight", true);
        //}
        //else
        //{
        //    animator.SetBool("MoveLeft", true);
        //}
    }
}