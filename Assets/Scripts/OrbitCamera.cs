using System;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    // variable target, available in fields
    [SerializeField] private Transform target;
    [SerializeField] private Transform pivot;
    [SerializeField] float angularSpeed = 50f;
    [SerializeField] float zoomSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log(Input.inputString);
        }
            if (target != null)
        {
            // look at target
            transform.LookAt(target);
        }
            
        if (pivot != null)
        {
            // if ZQSD pressed : orbite autour du pivot (axe Y ou Z)
            if (Input.GetKey(KeyCode.Q))
            {
                transform.RotateAround(pivot.position, Vector3.up, angularSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.RotateAround(pivot.position, Vector3.down, angularSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.Z))
            {
                transform.RotateAround(pivot.position, Vector3.left, angularSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.RotateAround(pivot.position, Vector3.right, angularSpeed * Time.deltaTime);
            }
            // if Mouse wheel scrolled, zoom to/unzoom from target
            if (Input.mouseScrollDelta.y != 0f)
            {
                if (Input.mouseScrollDelta.y > 0f && Vector3.Distance(transform.position, target.position) < 2 + (zoomSpeed * Input.mouseScrollDelta.y * Time.deltaTime)) return;
                transform.position = Vector3.MoveTowards(transform.position, target.position, zoomSpeed * Input.mouseScrollDelta.y * Time.deltaTime);
            }
        }
    }
}
