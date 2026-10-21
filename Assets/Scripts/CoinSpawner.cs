using UnityEngine;
using UnityEngine.UIElements;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    public GameObject[] coins;
    void Start()
    {

        coins = new GameObject[10];

        //Set the length and the depth here
        int CoinLength = 5;
        int CoinDepth = 4;
        float CoinSpacing = 10;

        //Main loop the coins, checking length
        for (int i = 0; i < CoinLength; i++)

        {

            coins[i] = coinPrefab;
            float xpos = i * CoinSpacing;

            //second loop to check for depth
            for (int p = 0; p < CoinDepth; p++)
            {
                float zpos = p * CoinSpacing;
                Vector3 positionoffsetD = new Vector3((xpos + (float)Random.Range(0, 10)), 1, (zpos + (float)Random.Range(0, 15)));

                Instantiate(coins[i], positionoffsetD, Quaternion.Euler(270, 0, 0));
                //Once this is done goes back to the first loop to redo this loop
            }
 
        }

    }
}
