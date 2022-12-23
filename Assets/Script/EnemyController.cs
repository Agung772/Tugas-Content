using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public Transform design;
    private void Start()
    {
        design.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));
        Destroy(gameObject, 5);
    }
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
