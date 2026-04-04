using UnityEngine;

public class StickScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Hit a stick!");

            if (GameManager.instance != null)
            {
                GameManager.instance.ResetCoins();
            }
        }
    }
}