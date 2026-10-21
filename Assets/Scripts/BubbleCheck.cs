using UnityEngine;

public class BubbleCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        {
            BubbleCount PlayerCounter = other.GetComponent<BubbleCount>();

            if (PlayerCounter != null)
            {
                PlayerCounter.IncremenetBubbleCount();

            }

            else
            {

                Debug.Log("Error: Player is missing the script");
            }
        }
    }

}
