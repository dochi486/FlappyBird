using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollHorizontal : MonoBehaviour
{

    public float speedX = -1;
    //public float minX = -12;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        //if (minX > transform.position.x)
        //{
        //    //오른쪽으로 가로크기(20.48) *2 만큼 이동하게!
        //    transform.Translate(20.48f * 2, 0, 0);

        //}
        //Relocate보다 아래 꺼가 먼저 실행돼서 간격이 떴다. 
        transform.Translate(speedX * Time.deltaTime, 0, 0);
        //방법2
        //var pos = transform.position;
        //pos.x += speedX * Time.deltaTime;
        //transform.position = pos;
    }
}
