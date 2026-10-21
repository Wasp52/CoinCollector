using UnityEngine;

public class GoalMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float movespeed = 0.5f;
    public float amplitude = 0.5f;
    private Vector3 StartPos;
    void Start()
    {
        StartPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = Mathf.Sin(Time.time * movespeed) * amplitude;
        Vector3 newPos = StartPos + Vector3.up * verticalMovement;
        transform.position = newPos;
    }
}
