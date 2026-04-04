using UnityEngine;
using TMPro;

public class CoinScript : MonoBehaviour
{
    private TextMeshProUGUI coinText;

    private void Start()
    {
        coinText = GameObject.FindWithTag("CoinText")
                    .GetComponent<TextMeshProUGUI>();
    }

    void OnTriggerEnter2D(Collider2D collision)
{
    Debug.Log("Something touched coin");

    if (collision.CompareTag("Player"))
    {
        Debug.Log("Player detected");
        GameManager.instance.AddCoin();
        Destroy(gameObject);
    }
}
}