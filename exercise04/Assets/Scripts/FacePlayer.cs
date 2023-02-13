using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public GameObject collectible;
    public GameObject enemy;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //enemy = GameObject.FindGameObjectWithTag("Enemy");
        //collectible = GameObject.FindGameObjectWithTag("Collectible");
    }

    // Update is called once per frame
    void Update()
    {
        enemy.transform.LookAt(player.transform);
        collectible.transform.LookAt(player.transform);
    }
}
