using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    
    private float mouseX;
    private float mouseY;
    private float xRotation;
    private float yRotation;

    [SerializeField] private GameObject player;

    

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxisRaw("Mouse X");
        mouseY = Input.GetAxisRaw("Mouse Y");

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90, 90);

        yRotation += mouseX;

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);

        player.transform.Rotate(Vector3.up * mouseX);                                                   
        
    }
}
