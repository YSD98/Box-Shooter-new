using UnityEngine;
public class MouseControl : MonoBehaviour
{
    public GameObject Cam;
    void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X"));
        Cam.transform.Rotate(Vector3.left * Input.GetAxis("Mouse Y"));
    }
}
