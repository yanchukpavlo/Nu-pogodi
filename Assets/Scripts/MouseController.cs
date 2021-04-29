using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseController : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 100f;

    Transform playerBody;
    float xRotation = 0f;

    float mouseX;
    float mouseY;

    void Start()
    {
        playerBody = FindObjectOfType<PlayerMovement>().transform;
    }

    void Update()
    {
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -85f, 85f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    public void OnRotationX(InputAction.CallbackContext Context)
    {
        mouseX = Context.ReadValue<float>();
        mouseX = mouseX * mouseSensitivity * Time.deltaTime;
    }

    public void OnRotationY(InputAction.CallbackContext Context)
    {
        mouseY = Context.ReadValue<float>();
        mouseY = mouseY * mouseSensitivity * Time.deltaTime;
    }
}
