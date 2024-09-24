using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    private float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Lcoks the cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Controls xAxis of mouse (left and right)
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        //Controls y axis of mouse (up and down)
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //Controls "nodding" of player
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -45f, 45f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //Controls looking left and right for player
        playerBody.Rotate(Vector3.up * mouseX);


    }
}
