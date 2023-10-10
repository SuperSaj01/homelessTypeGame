using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{

    public event Action PlayerInteract;

    [SerializeField] private float speed = 4f;
    private float walkSpeed = 4;
    private float runSpeed = 9;

    public float range = 2.5f;

    private float horizontal;
    private float vertical;
    private Vector3 moveDir;

    public Camera cam;

    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;


    public bool isMoving;

    void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);
    }

    void Start()
    {
        PlayerInteract += Interact;
    }

    
    void Update()
    {
        MoveInput();

        if(Input.GetKeyDown(KeyCode.E))
        {
            PlayerInteract?.Invoke();
        }
        
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
        }
        else 
        {
            speed = walkSpeed;
        }

    }

    void Interact()
    {

        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out RaycastHit hit, range))
        {
            if(hit.transform.TryGetComponent(out IIinteractable interactable))
            {
              interactable.onPlayerInteract();
            }
        }
        
                
        
    }

}
