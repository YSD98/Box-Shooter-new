using UnityEngine;
public class Bullet : MonoBehaviour
{
    Rigidbody rg;
    void Start()
    {
        rg = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        rg.AddForce(transform.forward * 50.0f, ForceMode.VelocityChange);
    }
    void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
