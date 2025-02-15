using UnityEngine;

public class SpawnHugo : MonoBehaviour
{
    [SerializeField] private GameObject RandoPref;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(RandoPref, new Vector3(0, 10, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
