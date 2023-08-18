using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GrapplingRope ropeReference;
    public GameObject player;
    public Transform Destination;

    public AudioSource TPSound;
    public Vector3 addPos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ropeReference.isGrappling == false)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                if (Vector2.Distance(player.transform.position, transform.position) > 0.3f)
                {
                    player.transform.position = Destination.position + addPos;
                    TPSound.Play();
                }
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
        }

    }
  
