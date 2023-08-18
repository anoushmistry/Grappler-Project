using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOScript : MonoBehaviour
{
    public GameObject PlayerGameObj;
    public Transform target;         // Reference to the groundchecker's transform
    public float followSpeed = 5f;   // Speed at which the object follows the player
    public float followDuration = 5f; // Duration in seconds for following the player

    private float elapsedTime = 0f;  // Elapsed time since following started

    public Animator burstanimator;

    private void Update()
    {
        // Check if the elapsed time is within the follow duration
        if (elapsedTime < followDuration)
        {
            // Calculate the direction towards the player
            Vector3 directionToPlayer = target.position - transform.position;


            // Calculate the movement step based on speed and frame rate
            float step = followSpeed * Time.deltaTime;

            // Move the object towards the player
            transform.position += directionToPlayer.normalized * step;

            // Update the elapsed time
            elapsedTime += Time.deltaTime;
        }
        if (elapsedTime >= followDuration)
        {
            burstanimator.SetFloat("Time", 6);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(UFODestroy());
            //Burst animation code here
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            burstanimator.SetFloat("Time", 6);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(UFODestroy());
        }
        if(collision.gameObject.CompareTag("Grappleable"))
        {
            burstanimator.SetFloat("Time", 6);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(UFODestroy());
        }
    }
    private IEnumerator UFODestroy()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
