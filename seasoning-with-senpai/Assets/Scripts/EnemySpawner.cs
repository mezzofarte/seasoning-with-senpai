using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemySpawn;
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        int randomDistance = Random.Range(30, 60);
        Vector3 spawnLocation = new Vector3(enemySpawn.transform.position.x+randomDistance, enemySpawn.transform.position.y, enemySpawn.transform.position.z);
        
        GameObject enemy = Instantiate(enemyPrefab, spawnLocation, enemySpawn.transform.rotation);
        Enemy enemyScript = enemy.GetComponent<Enemy>();
        enemy.transform.SetParent(enemySpawn.transform);
        //enemyScript.initialize(enemySpawn.GetComponent<CapsuleCollider>().radius, enemySpawn.transform);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
