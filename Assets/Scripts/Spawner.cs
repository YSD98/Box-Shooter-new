using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject[] spawnerr;
    void Start()
    {
        InvokeRepeating("Spawn",.5f,1.5f);
    }
    void Spawn()
    {
        Vector3 pos;
        pos.x = Random.Range(-5,5);
        pos.y = 0;
        pos.z = 10;
        int objj = Random.Range(0,spawnerr.Length+1);
        GameObject obj = Instantiate(spawnerr[objj],pos,Quaternion.identity);
        obj.transform.parent = gameObject.transform;
        Debug.Log(objj);
    }
}
