using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bulletPrefab;
    public GameObject playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //1. 발사버튼을 누르면
        if(Input.GetButtonDown("Fire1"))
        {
            //2. 총알을 만든다
            GameObject bullet = Instantiate(bulletPrefab);

            //3. 총알이 움직이는 건 bullet.cs에서 설정했기 때문에 총알의 위치만 선정한다. 
            bullet.transform.position = playerPosition.transform.position;
        }
    }
}
