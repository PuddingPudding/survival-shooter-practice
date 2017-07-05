using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowMyself : MonoBehaviour
{

    public Transform target;
    public float smoothing = 5f;

    Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - target.position;
    }

    private void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
