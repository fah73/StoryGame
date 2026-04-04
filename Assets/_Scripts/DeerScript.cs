using UnityEngine;

public class DeerScript : MonoBehaviour
{
    public TradeManager tradeManager;

    void OnMouseDown()
    {
        Debug.Log("Deer clicked!");

        if (GameManager.instance != null)
        {
            GameManager.instance.ResetCoins();
        }

        if (tradeManager != null)
        {
            tradeManager.Swap();
        }
    }
}