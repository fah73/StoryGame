using UnityEngine;

public class LevelTitle : MonoBehaviour
{
    void Start()
    {
        Invoke("HideTitle", 2f);
    }

    void HideTitle()
    {
        gameObject.SetActive(false);
    }
}