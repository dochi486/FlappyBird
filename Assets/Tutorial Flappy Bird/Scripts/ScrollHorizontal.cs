using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollHorizontal : MonoBehaviour
{

    public float speedX = -1;
    public float minX = -12;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

        if (minX > transform.position.x)
        {
           //���������� ����ũ��(20.48) *2 ��ŭ �̵��ϰ�!
           transform.Translate(20.48f * 2, 0, 0);

        }
        //Relocate���� �Ʒ� ���� ���� ����ż� ������ ����. 
        transform.Translate(speedX * Time.deltaTime, 0, 0);
        //���2
        //var pos = transform.position;
        //pos.x += speedX * Time.deltaTime;
        //transform.position = pos;
    }
}
