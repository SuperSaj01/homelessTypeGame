using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private float speed = 4f;
    private float walkSpeed = 4;
    private float runSpeed = 9;
    
    private float horizontal;
    private float vertical;
    private Vector3 moveDir;

    public bool isMoving;

    void Start()
    {
        
    }

    
    void Update()
    {
        MoveInput();
        

    }

    void MoveInput()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        moveDir = transform.right * horizontal + transform.forward * vertical;
        if(moveDir != Vector3.zero) isMoving = true; else isMoving = false;
        transform.position += moveDir * speed * Time.deltaTime;

        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = runSpeed;
            Debug.Log("Running");
        }
        else 
        {
            speed = walkSpeed;
        }

    }
}
