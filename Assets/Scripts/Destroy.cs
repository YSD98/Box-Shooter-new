using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField]private float _TimeToDestroy = 5f;
    void Update()
    {
        if(this.gameObject.tag != "Bullet")
        {
            transform.Translate(Vector3.back * Time.deltaTime);
            Destroy(gameObject,_TimeToDestroy);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(this.gameObject.tag == "Bullet")
            Destroy(gameObject);
        if(other.gameObject.tag == "Bullet")
            Destroy(gameObject);
    }
}
