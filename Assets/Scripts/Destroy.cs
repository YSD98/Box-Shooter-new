using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField]private float _TimeToDestroy = 5f;
    void Update()
    {
        Destroy(gameObject,_TimeToDestroy);
    }
}
