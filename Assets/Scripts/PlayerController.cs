using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 20;
    public float mouseSensitivity = 100f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontal);
        transform.Translate(Vector3.up * speed * Time.deltaTime * vertical);

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        Vector3 rotation = transform.eulerAngles;
        rotation.x -= mouseY;
        rotation.y += mouseX;
        transform.eulerAngles = rotation;
    }
}