using UnityEngine;
using System;
public class PlayerForce : MonoBehaviour
{
    [SerializeField] private GrapplingRope grappleRope;
    public GrapplingGun grappleGun;
    public float swingForce = 10f;
    public LineRenderer lineRenderer;
    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        if (grappleRope.isGrappling == true && grappleGun.launchType != LaunchType.Transform_Launch)
        {
            if(Input.GetKeyDown(KeyCode.W))
            {
                ApplyUpForce(1f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                ApplyUpForce(-1f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                ApplySwingForce(-1f);
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                ApplySwingForce(1f);
            }
        }
    }

    private void ApplyUpForce(float direction)
    {
        rb.AddForce(transform.up * direction * swingForce, ForceMode2D.Impulse);
    }
    private void ApplySwingForce(float direction)
    {
        rb.AddForce(transform.right * direction * swingForce, ForceMode2D.Impulse);
        UpdateLineRenderer();
    }

    private void UpdateLineRenderer()
    {
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, transform.position + transform.right * 2f);
    }
   
}