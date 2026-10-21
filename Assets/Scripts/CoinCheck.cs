using UnityEngine;

public class CoinCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            CoinCount PlayerCounter = other.GetComponent<CoinCount>();

            if (PlayerCounter != null)
            {
                PlayerCounter.IncremenetCoinCount();

                Destroy(gameObject);
            }

            else
            {

                Debug.Log("Error: Player is missing the script");
            }
        }
    }

}

