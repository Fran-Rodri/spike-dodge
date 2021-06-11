using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject spikePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnSpike", 1f, 1f);
    }

    private void spawnSpike() 
    {
        Vector3 position = new Vector3(Random.Range(-5.77f,5.77f),3.64f,0);
        GameObject spawnedSpike = Instantiate(spikePrefab);
        spawnedSpike.transform.position = position;
    }
}
