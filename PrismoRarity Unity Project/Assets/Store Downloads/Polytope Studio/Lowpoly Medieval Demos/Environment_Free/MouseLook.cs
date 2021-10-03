using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivityUpDownY = 100f;
    public float mouseSensitivityLeftRightX = 100f;

    public Transform playerBody;

    private float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        xRotation = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //xRotation = 0f;
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivityLeftRightX * Time.deltaTime;
        
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivityUpDownY * Time.deltaTime;
        //xRotation = 0f;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -15f, 32f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
