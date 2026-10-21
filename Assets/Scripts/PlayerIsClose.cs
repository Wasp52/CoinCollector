using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform Player;
    public float DetectDistance = 5.0f;
    
    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, Player.position);

        if (distanceToPlayer <= DetectDistance)
        {
            Debug.Log("player is close enough");
        }
    }
}
