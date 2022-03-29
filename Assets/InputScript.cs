using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputScript : MonoBehaviour
{
    Rigidbody rb;

    public float speed;

    public float jumpforce;

    public void Move(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();
        moveInput = moveInput * speed;
        rb.velocity = new Vector3(moveInput.x, rb.velocity.y, moveInput.y);
    }

    public void Run(InputAction.CallbackContext context)
    {

    }

    public void Jump(InputAction.CallbackContext context)
    {
        rb.AddForce(Vector2.up * jumpforce);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
