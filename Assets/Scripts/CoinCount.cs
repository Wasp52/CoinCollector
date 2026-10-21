using UnityEngine;

public class CoinCount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int coinsCollected = 0;
    void Start()
    {
        Debug.Log("Coin counter initiated: " + coinsCollected);
    }

    public void IncremenetCoinCount()
    {
        coinsCollected = coinsCollected + 1;

        Debug.Log("Coin collected! New coin count: " + coinsCollected);
    }
}
