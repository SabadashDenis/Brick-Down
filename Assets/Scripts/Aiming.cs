using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
    [SerializeField]
    private Joystick joystick;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    private void Rotate()
    {
        if (joystick.Vertical > 0)
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + joystick.Horizontal * 90, transform.rotation.z);
        if (joystick.Vertical < 0)
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + 180 - joystick.Horizontal * 90, transform.rotation.z);

    }

    void Update()
    {
        Rotate();
        Ray ray = new Ray(transform.position, transform.forward);

        if (startPosition == transform.position)
            Debug.DrawRay(transform.position, transform.forward * 15, Color.red, Time.deltaTime);
    }
}
