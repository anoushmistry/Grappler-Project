using UnityEngine;
using System.Collections;
using TMPro;

public class AnimationScript : MonoBehaviour {

    public float fadeDuration = 1.0f; // Duration of the fade in and fade out in seconds

    private TextMeshProUGUI textComponent;
    private Color originalColor;
    private Color transparentColor;

    private void Start()
    {
        textComponent = GetComponent<TextMeshProUGUI>();
        originalColor = textComponent.color;
        transparentColor = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);

        // Start the fade-in animation
        StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            textComponent.color = Color.Lerp(transparentColor, originalColor, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Wait for a short time at full opacity
        yield return new WaitForSeconds(1.0f);

        // Start the fade-out animation
        //StartCoroutine(FadeOut());
    }

    private IEnumerator FadeOut()
    {
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            textComponent.color = Color.Lerp(originalColor, transparentColor, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Once the fade-out is complete, you can disable the GameObject or trigger other actions
        gameObject.SetActive(false);
    }
}

