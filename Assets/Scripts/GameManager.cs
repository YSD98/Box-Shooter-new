using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField]private TMP_Text score;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Hello";
    }
}
