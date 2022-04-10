using UnityEngine;
public class Shooter : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Cam;
    void Update()
    {
        if(Input.GetButtonDown("Fire1")||Input.GetButtonDown("Jump"))
        {
            if(Bullet)
            {
                GameObject newProjectile = Instantiate(Bullet, Cam.transform.position + Cam.transform.forward, Cam.transform.rotation) as GameObject;
                if (!newProjectile.GetComponent<Rigidbody>()) 
				{
					newProjectile.AddComponent<Rigidbody>();
				}
				// Apply force to the newProjectile's Rigidbody component if it has one
				newProjectile.GetComponent<Rigidbody>().AddForce(Cam.transform.forward * 50.0f, ForceMode.VelocityChange);
                Destroy(newProjectile,2f);
            }
        }
    }
}
