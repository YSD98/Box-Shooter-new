using UnityEngine;
public class Obj : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.back * .03f);
        Destroy(gameObject,5f);
        if(gameObject.name == "Time")
        {
            
        }
        if(gameObject.name == "Enemy")
        {

        }
        if(gameObject.name == "Friend")
        {

        }
    }
}
