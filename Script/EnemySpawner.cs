using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemy;
    private float spawnInterval = 2f;
    
    // Update is called once per frame
    void Update()
    {
        //enemy = Instantiate(enemy);
    }
}
