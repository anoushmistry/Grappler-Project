using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFlip : MonoBehaviour
{
    //reference for flipping player
    public PlayerBehaviour pb;
   
    // Update is called once per frame
    void Update()
    {
       
            

            Vector3 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);



            Vector3 aimLocalScale = Vector3.one;
            if (angle > 90 || angle < -90)
            {
                aimLocalScale.y = -2.1f;
                aimLocalScale.x = 2.1f;
                pb.sp.flipX = true;
            }
            else
            {
                aimLocalScale.y = 2.1f;
                aimLocalScale.x = 2.1f;
                pb.sp.flipX = false;
                
            }
            transform.localScale = aimLocalScale;



    }
}
