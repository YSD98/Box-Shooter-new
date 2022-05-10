using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
            transform.Translate(Vector3.back * Time.deltaTime);
            Destroy(gameObject,5);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Spawner")
            Destroy(other.gameObject);
            Destroy(gameObject);
    }
}
