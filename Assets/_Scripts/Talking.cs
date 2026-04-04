using UnityEngine;
using TMPro;

public class EndDialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    private string[] lines = new string[]
    {
        "You made it to the end!", 
        "Click the Deer to pay her your coins and get your teacup back!",
        "The End!"
    };

    private int index = 0;

    void Start()
    {
        dialogueText.text = lines[index];
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
        index++;

        if (index < lines.Length)
        {
            dialogueText.text = lines[index];
        }
        else
        {
            Debug.Log("THE END");
        }
    }
}