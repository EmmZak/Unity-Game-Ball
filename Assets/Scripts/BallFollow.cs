using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFollow : MonoBehaviour
{
    public Transform PlayerTransform;

    private Vector3 cam;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        cam = transform.position - PlayerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = PlayerTransform.position + cam;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);
    }
}
