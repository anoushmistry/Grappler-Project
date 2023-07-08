using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAstronaut : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3 rotateAmt;
    public float moveSpeed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateAmt * Time.deltaTime);

        rb.velocity = transform.right * moveSpeed;
    }
}
