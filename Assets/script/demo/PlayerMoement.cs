using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoement : MonoBehaviour
{
    public float moveSpeed;
    private Vector2 moveInput;
    public Rigidbody2D rb2D;
    void Start()
    {
        
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        Debug.Log(moveInput.x);
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rb2D.velocity = moveInput * moveSpeed;
        rb2D.AddForce(moveSpeed * (moveInput * Time.deltaTime));
    }
}
