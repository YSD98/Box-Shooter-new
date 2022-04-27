using UnityEngine;
public class PlayerControl : MonoBehaviour
{
    private float rotationX = 30f, rotationY = 0.0f;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        
        rotationY +=  Input.GetAxis("Mouse X");
        // rotationY -=  Input.GetAxis("Mouse Y");

        // rotationX = Mathf.Clamp(rotationX, -30f, 30f);
        rotationY = Mathf.Clamp(rotationY, -40f, 40f);

        transform.eulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
