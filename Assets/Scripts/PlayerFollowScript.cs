using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowScript : MonoBehaviour
{
    public float smoothTime = 10f;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private Transform target;
    public Vector3 offset = new Vector3();
    private void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime * Time.deltaTime);
        /*if (target)
        {
            transform.position = target.position + offset;
        }*/
    }
}
