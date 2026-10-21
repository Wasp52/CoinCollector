using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int coinsCollected = 0;
    private bool Paused = false;

    public void AddCoinsCollected(int amount)
    { 
        
        if (coinsCollected >= 20)
        {
            Debug.Log("You Won!");
        }

    }
    void Update()
    {
        Pause();
    }
    void Pause()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Paused)
            {
                Time.timeScale = 1.0f;
                Debug.Log("Game is unpaused");
            }
            else
            {
                Time.timeScale = 0.0f;
                Debug.Log("Game is paused");
            }
            Paused = !Paused;
        } 

    }
}
