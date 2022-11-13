using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;

    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        int randValue = UnityEngine.Random.Range(0,10);
        if(randValue <= 3)
        {
            GameObject target = GameObject.Find("Player");  //Target 찾기
            dir = target.transform.position - transform.position; //방향 구하기
            dir.Normalize();    //방향의 크기를 1로
        }
        else
        {
            dir = Vector3.down;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;        
    }

    private void OnCollisionEnter(Collision other)
    {
        //충돌시작
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
    private void OnCollisionStay(Collision other)
    {
        //충돌중
    }
    private void OnCollisionExit(Collision other)
    {
        //충돌끝
    }
}
