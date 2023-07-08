using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleController : MonoBehaviour
{
    public float speed = 1.0f; // The speed at which the scale changes

    public Vector3 temp;

    public Vector3 rotateAmount;


    private void Update()
    {
        temp = transform.localScale;
        temp.x -= Time.deltaTime * speed;

        temp.y -= Time.deltaTime * speed;
        temp.z -= Time.deltaTime * speed;

        transform.localScale = temp;

        Vector3 dummy = new Vector3(0, 0, 0);

        if(transform.localScale.x < 0.01 || transform.localScale.y < 0.01 || transform.localScale.y < 0.01)
        {
            gameObject.SetActive(false);
        }
    }

    private void LateUpdate()
    {
        transform.Rotate(Time.deltaTime * rotateAmount);
    }


}
