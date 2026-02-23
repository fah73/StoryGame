using UnityEngine;

public class FoxSpeechBubble : MonoBehaviour
{
    public GameObject foxTextBubble;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foxTextBubble.SetActive(false);
    }

    void OnMouseDown()
    {
        foxTextBubble.SetActive(!foxTextBubble.activeSelf);
    }
}


