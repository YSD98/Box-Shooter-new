using UnityEngine;

public class Destroy : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject,5f);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Bullet")
            Destroy(gameObject);
    }
}
