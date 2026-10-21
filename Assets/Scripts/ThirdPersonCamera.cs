using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform target;

    public float distance = 5.0f;
    public float sense = 2.0f;
    public float offset = 1.0f;

    public float rotx = 0.0f;
    public float roty = 0.0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        float mouseX = Input.GetAxis("Mouse X") * sense;
        float mouseY = Input.GetAxis("Mouse Y") * sense;
=======
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
>>>>>>> Stashed changes

        rotx += mouseY;
        roty -= mouseX;

        rotx = Mathf.Clamp(rotx, -90, 90);

        transform.localRotation = Quaternion.Euler(rotx, roty, 0);
    }

    private void LateUpdate()
    {
        Vector3 targetOffset = target.position - target.forward * distance + Vector3.up * offset;

        transform.position = targetOffset;

        transform.LookAt(target);
    }
}
