using UnityEngine;

public class Destroy : MonoBehaviour
{
    void Update()
    {
        transform.Translate(new Vector3(0,0,-0.05f));
        Destroy(gameObject,5f);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Bullet")
            Destroy(gameObject);
    }
}
