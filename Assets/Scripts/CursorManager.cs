using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] private GameManager gm;
    public Texture2D crosshairTexture;
    public Vector2 cursorHotspot;

    private void Start()
    {
      
        cursorHotspot = new Vector2(crosshairTexture.width / 2, crosshairTexture.height / 2);
        Cursor.SetCursor(crosshairTexture, cursorHotspot, CursorMode.Auto);
       
    }
    private void Update()
    {
        Cursor.SetCursor(crosshairTexture, cursorHotspot, CursorMode.Auto);
    }

}