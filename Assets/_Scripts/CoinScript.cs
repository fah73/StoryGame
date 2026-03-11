using UnityEngine;

public class CoinScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Something touched the coin");

        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player collected coin");

            GameManager.instance.AddCoin();

            Destroy(gameObject);
        }
    }
}