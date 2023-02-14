using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public float timer = 2f;
    private Vector3 collectibleSpacing;
    private Vector3 enemySpacing;
    public GameObject collectible;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        collectibleSpacing = new Vector3(Random.Range(-20, 20), 0, Random.Range(2, 20));
        enemySpacing = new Vector3(Random.Range(-20, 20), 0, Random.Range(6, 20));
        Instantiate(collectible, transform.position + collectibleSpacing, Quaternion.identity);
        Instantiate(enemy, transform.position + enemySpacing, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        collectibleSpacing = new Vector3(Random.Range(-20, 20), 0, Random.Range(2, 20));
        enemySpacing = new Vector3(Random.Range(-20, 20), 0, Random.Range(2, 20));

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Instantiate(collectible, transform.position + collectibleSpacing, Quaternion.identity);
            Instantiate(enemy, transform.position + enemySpacing, Quaternion.identity);
            
            timer = 2f;
        }
        
    }
}
