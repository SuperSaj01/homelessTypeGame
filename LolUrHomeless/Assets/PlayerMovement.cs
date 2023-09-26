using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private float speed = 4f;
    private float horizontal;
    private float vertical;
    private Vector3 moveDir;

    void Start()
    {
        
    }

    
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        moveDir = transform.right * horizontal + transform.forward * vertical;

        transform.position += moveDir * speed * Time.deltaTime;

    }
}
