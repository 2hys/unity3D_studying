using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefeb;
    [SerializeField]
    private float sparmerInterval = 3.5f;

    private void Start()
    {
        StartCoroutine(SpawnEnemy(sparmerInterval, enemyPrefeb));
    }
    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {

        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), 0, Random.Range(-6, 6f)), Quaternion.identity);
        StartCoroutine(SpawnEnemy(interval, enemy));
    }
}
