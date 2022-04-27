using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject[] spawnerr;
    void Update()
    {
        Vector3 pos;
        pos.x = Random.Range(-5,5);
        pos.y = -5;
        pos.z = 10;
        int objectToSpawn = Random.Range (0, spawnerr.Length);
        if(Input.GetKeyDown(KeyCode.F))
        {
            GameObject inst = Instantiate(spawnerr[objectToSpawn],pos,transform.rotation) as GameObject;
            inst.transform.Translate(Vector3.forward);
            // inst.transform.parent = gameObject.transform;
        }
    }
}
