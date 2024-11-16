using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSMover : MonoBehaviour
{
    public float speed = 5f;  // Speed of movement
    public float rotationSpeed = 100.0f; // Adjust the rotation speed

    private float yaw = 0.0f;
    private float pitch = 90.0f;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        // Check if "W" key is pressed for moving up
        if (Input.GetKey(KeyCode.W))
        {
            Invoke("MoveUp", .5f);
        }

        // Check if "S" key is pressed for moving down
        if (Input.GetKey(KeyCode.S))
        {
            Invoke("MoveDown", .5f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Invoke("MoveLeft", .5f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Invoke("MoveRight", .5f);
        }


        // Get mouse movement input
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

        // Accumulate rotation values
        yaw += mouseX;
        pitch -= mouseY;

        // Apply rotation to the object
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

    // Function to move the object up
    void MoveUp()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    // Function to move the object down 
    void MoveDown()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    void MoveRight()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    void MoveLeft()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}