using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemy;

    public float spawnRate = 1f;
    // Start is called before the first frame update
    void Start()
    {
        enemy.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
