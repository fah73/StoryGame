using UnityEngine;

public class TradeManager : MonoBehaviour
{
    public Transform coin;
    public Transform teacup;

    public void Swap()
    {
        if (coin == null || teacup == null)
        {
            Debug.LogError("Coin or Teacup not assigned!");
            return;
        }

        Vector3 coinPos = coin.position;
        Vector3 teacupPos = teacup.position;

        coin.position = teacupPos;
        teacup.position = coinPos;

        Debug.Log("Trade complete!");
    }
}