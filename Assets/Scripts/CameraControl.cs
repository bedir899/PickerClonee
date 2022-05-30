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
        offset.x = -10;
        offset.y = 4f;
        offset.z = 0f;
    }
    private void LateUpdate()
    {
        Vector3 desPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desPos, lerpValue);
    }
}
