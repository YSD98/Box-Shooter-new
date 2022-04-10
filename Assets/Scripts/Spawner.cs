using UnityEngine;
public class Spawner : MonoBehaviour
{
    public float secondsBetweenSpawning = 0.1f;
    public GameObject Timee;
    public GameObject Enemy;
    public GameObject Friend;
    private float nextSpawnTime;
    void Start()
    {
        nextSpawnTime = Time.time+secondsBetweenSpawning;
    }
    void Update()
    {
        Vector3 pos ;
        pos.x = Random.Range(-10,10);
        pos.y = Random.Range(5,10);
        pos.z = Random.Range(-10,10);
        if (Time.time  >= nextSpawnTime) {
			// Spawn the game object through function below
			GameObject Tm =  Instantiate(Timee,pos,Quaternion.identity);

			// determine the next time to spawn the object
			nextSpawnTime = Time.time+secondsBetweenSpawning;
            Destroy(Tm,1f);
		}
    }
}
