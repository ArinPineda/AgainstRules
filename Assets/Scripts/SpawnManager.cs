using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] Transform[] pointToStart;
    public int countEnemy =0;
    float posX;
    float time;
    // Update is called once per frame

    private void Start()
    {
        InvokeRepeating("Spawner", 1, 1.5f);
        
    }
    void Update()
    {
        
    }
    void Spawner()
    {

        int randonE = Random.Range(0, enemies.Length);
        int valueR = Random.Range(0, 2);
        posX = Random.Range(-7, 7);    
        Vector2 posRandom = new Vector2(posX, 6);
        Instantiate(enemies[randonE], posRandom, transform.rotation);
            
    }
}
