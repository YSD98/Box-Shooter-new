using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject[] spawnerr;
    void Start()
    {
        InvokeRepeating("Spawn",.5f,1f);
    }
    void Spawn()
    {
        Vector3 pos;
        pos.x = Random.Range(-5,5);
        pos.y = -5;
        pos.z = 10;
        int objj = Random.Range(0,spawnerr.Length);
        GameObject obj = Instantiate(spawnerr[objj],pos,Quaternion.identity);
        obj.transform.parent = gameObject.transform;
    }
}
