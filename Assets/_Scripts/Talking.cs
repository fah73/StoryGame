using UnityEngine;
using TMPro;

public class Talking : MonoBehaviour
{
    public TMP_Text dialogueText;

    string[] dialogueLines =
    {
        "Player: Hey! You stole my teaset!",
        "Deer: Oh this? I found it.",
        "Player: You ran off with it!",
        "Deer: If you want it back, it'll cost you.",
        "Player: Fine... how much?",
        "Deer: 30 coins.",
        "Player: Deal. I'll take it back.",
        "You bought back the teaset!"
    };

    int currentLine = 0;

    void Start()
    {
        dialogueText.text = dialogueLines[currentLine];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NextLine();
        }
    }

    void NextLine()
    {
        currentLine++;

        if(currentLine < dialogueLines.Length)
        {
            dialogueText.text = dialogueLines[currentLine];
        }
        else
        {
            dialogueText.text = "THE END";
        }
    }
}