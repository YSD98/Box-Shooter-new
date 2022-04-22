using UnityEngine;
public class Spawner : MonoBehaviour
{
    public float secondsBetweenSpawning = 0.1f;
    public GameObject[] spawnerr;
    private float nextSpawnTime;
    void Start()
    {
        nextSpawnTime = Time.time+secondsBetweenSpawning;
    }
    void Update()
    {
        Vector3 pos ;
        pos.x = Random.Range(-5,5);
        pos.y = Random.Range(2,5);
        pos.z = 10;
        if (Time.time  >= nextSpawnTime) {
			// Spawn the game object through function below
            int objectToSpawn = Random.Range (0, spawnerr.Length);
			GameObject Tm = Instantiate (spawnerr [objectToSpawn], pos, transform.rotation) as GameObject;

			// determine the next time to spawn the object
			nextSpawnTime = Time.time+secondsBetweenSpawning;
            Tm.transform.parent = gameObject.transform;
		}
    }
}
