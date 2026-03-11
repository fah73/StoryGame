using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int coins = 0;
    public TMP_Text coinText;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateCoinUI();
    }

    public void AddCoin()
    {
        coins += 1;
        UpdateCoinUI();
        CheckLevelProgress();
    }

    void UpdateCoinUI()
    {
        coinText.text = "Coins: " + coins;
    }

    void CheckLevelProgress()
    {
        string scene = SceneManager.GetActiveScene().name;

        if(scene == "Level1" && coins >= 10)
        {
            SceneManager.LoadScene("Level2");
        }

        if(scene == "Level2" && coins >= 15)
        {
            SceneManager.LoadScene("Level3");
        }

        if(scene == "Level3" && coins >= 20)
        {
            SceneManager.LoadScene("Shop");
        }
    }
}