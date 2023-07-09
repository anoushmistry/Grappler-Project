using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D asteroidRb;
    public float asteroidSpeed;

    [SerializeField] private Animator animator;
    public GameManager gm;
    void Start()
    {
        asteroidRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        asteroidRb.velocity = new Vector2(asteroidSpeed, asteroidSpeed);
        animator.SetFloat("AsteroidSpeed", Mathf.Abs(asteroidRb.velocity.x));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.transform.gameObject.SetActive(false);
            gm.YouLose();
        }
        if(collision.gameObject.CompareTag("Bounds"))
        {
            gameObject.SetActive(false);
            Debug.Log("Asteroid Crashed!!!!");
        }
    }
}
