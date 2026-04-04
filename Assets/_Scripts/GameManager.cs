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
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        coinText = GameObject.FindWithTag("CoinText")?.GetComponent<TMP_Text>();

        if (coinText != null)
        {
            coinText.text = coinCount.ToString();
        }
    }

    public void AddCoin()
    {
        coinCount++;
        if (coinText != null)
        {
            coinText.text = coinCount.ToString();
        }
        CheckLevelProgress();
    }

    void CheckLevelProgress()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        if (sceneName == "Level1" && coinCount >= 5)
            SceneManager.LoadScene("Level2");

        if (sceneName == "Level2" && coinCount >= 15)
            SceneManager.LoadScene("Level3");

        if (sceneName == "Level3" && coinCount >= 30)
            SceneManager.LoadScene("EndTrade");
    }
    public void ResetCoins()
{
    coinCount = 0;

    if (coinText != null)
    {
        coinText.text = coinCount.ToString();
    }
}

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}