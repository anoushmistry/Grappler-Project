using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObject : MonoBehaviour
{
    public Vector3 rotateAmount;

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        transform.Rotate(rotateAmount * Time.deltaTime);
    }
}
