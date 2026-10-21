using UnityEngine;

public class BubbleCount : MonoBehaviour
{
    private int bubblesCollected = 0;
    void Start()
    {
        Debug.Log("Bubble counter initiated: " + bubblesCollected);
    }

    public void IncremenetBubbleCount()
    {
        bubblesCollected = bubblesCollected + 1;

        Debug.Log("Bubble collected! New bubble count: " + bubblesCollected);
    }
}
