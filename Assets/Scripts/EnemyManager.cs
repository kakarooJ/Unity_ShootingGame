using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    float currentTime;
    
    public float minTime = 1;
    public float maxTime = 5;

    float createTime = 1;    //1초
    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {        
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > createTime)
        {
            GameObject enemy = Instantiate(enemyPrefab);
            enemy.transform.position = transform.position;
            currentTime = UnityEngine.Random.Range(minTime, maxTime);
        }        
    }
}
