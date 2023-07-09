using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FinishLineScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color[] colors;
    public float changeInterval = 0.1f;

    private float timer;
    private int currentIndex = 0;

    private void Start()
    {
        // Make sure you assign the SpriteRenderer component of your sprite to the spriteRenderer variable in the inspector
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Start the color change coroutine
        StartCoroutine(ChangeColor());
    }

    private System.Collections.IEnumerator ChangeColor()
    {
        while (true)
        {
            // Change the sprite color to the next color in the array
            spriteRenderer.color = colors[currentIndex];

            // Increment the index
            currentIndex = (currentIndex + 1) % colors.Length;

            // Wait for the specified interval before changing the color again
            yield return new WaitForSeconds(changeInterval);
        }
    }
}
