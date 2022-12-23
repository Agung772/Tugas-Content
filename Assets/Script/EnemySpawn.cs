using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject prefab;
    private void Start()
    {
        InvokeRepeating("Spawn", 0, 1);
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position + new Vector3(0, Random.Range(1,5), 0), transform.rotation);
    }
}
