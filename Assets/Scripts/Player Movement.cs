using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
<<<<<<< Updated upstream
    public float moveSpeed = 20.0f;
    public float MouseSense = 2.0f;
    private float verticalrot = 0.0f;
    private bool sprint = true;
=======
    public float moveSpeed = 10.0f;
    public float MouseSense = 2.0f;
    private float verticalrot = 0.0f;
>>>>>>> Stashed changes
    void Start()
    {
        
    }

<<<<<<< Updated upstream
    void Sprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

            if (sprint)
            {
                moveSpeed = 40.0f;
            }
            else
            {
                moveSpeed = 20.0f;
            }

            sprint = !sprint;
        }
    }

    // Update is called once per frame
    void Update()
    {

        Sprint();

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalrot = Input.GetAxis("Mouse X") * MouseSense;

=======
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalrot = Input.GetAxis("Mouse X") * MouseSense;
>>>>>>> Stashed changes
        Vector3 movementDirection = new Vector3(horizontalInput, 0f, verticalInput);
        verticalrot -= Input.GetAxis("Mouse Y") * MouseSense;
        verticalrot = Mathf.Clamp(verticalrot, -90, 90);

        transform.Translate(movementDirection * moveSpeed * Time.deltaTime);
        transform.Rotate(0, horizontalrot, 0);

<<<<<<< Updated upstream

        Camera.main.transform.localRotation = Quaternion.Euler(verticalrot, 0, 0);
    }

=======
        Camera.main.transform.localRotation = Quaternion.Euler(verticalrot, 0, 0);

    }
>>>>>>> Stashed changes
}
