using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int coinCount = 0;

    public TMP_Text coinText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCoin()
    {
        coinCount++;
        UpdateCoinUI();
        CheckLevelProgress();
    }

    void UpdateCoinUI()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + coinCount;
        }
    }

    void CheckLevelProgress()
    {
        string scene = SceneManager.GetActiveScene().name;

        if(scene == "Level1" && coinCount >= 5)
        {
            SceneManager.LoadScene("Level2");
        }

        if(scene == "Level2" && coinCount >= 15)
        {
            SceneManager.LoadScene("Level3");
        }

        if(scene == "Level3" && coinCount >= 30)
        {
            SceneManager.LoadScene("EndTrade");
        }
    }
}