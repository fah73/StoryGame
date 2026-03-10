using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject thief;
    public TextMeshProUGUI introText;

    void Start()
    {
        introText.text = "What a beautiful teaset!";
        Invoke("SpawnThief", 3f);
    }

    void SpawnThief()
    {
        thief.SetActive(true);
    }

    public void ShowChaseText()
    {
        introText.text = "Catch that deer!";
    }
}