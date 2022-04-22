using UnityEngine;
public class MouseControl : MonoBehaviour
{
    private float rotationX = 0.0f, rotationY = 0.0f;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        
        rotationY +=  Input.GetAxis("Mouse X");
        rotationX -=  Input.GetAxis("Mouse Y");

        rotationX = Mathf.Clamp(rotationX, -30f, 0f);
        rotationY = Mathf.Clamp(rotationY, -20f, 20f);

        transform.eulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
