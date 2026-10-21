using UnityEngine;

public class GoalSpin : MonoBehaviour
{

    public float RotSpeed = 50f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, RotSpeed * Time.deltaTime);
    }
}
