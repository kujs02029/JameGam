using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class elfGingerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    Vector2 input;
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            rb.MovePosition(rb.position + input * speed * Time.fixedDeltaTime);
    }

    private void Update()
    {
        input.y = Input.GetAxisRaw("Vertical");
        input.x = Input.GetAxisRaw("Horizontal");

        if(input.sqrMagnitude > 0.01f)
        {
            animator.SetFloat("Horizontal", input.x);
            animator.SetFloat("Vertical", input.y);
        }
        animator.SetFloat("Speed", input.sqrMagnitude);
    }
}
