using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform target;
    public static Vector3 offset;

    public float lerpValue;


    private void Start()
    {
        offset.x = 0;
        offset.y = 4.038f;
        offset.z = -6f;
    }
    private void LateUpdate()
    {
        Vector3 desPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desPos, lerpValue);
    }
}
