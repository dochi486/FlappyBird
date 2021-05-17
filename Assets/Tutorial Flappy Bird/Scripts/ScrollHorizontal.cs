using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollHorizontal : MonoBehaviour
{

    public float speedX = -1;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedX * Time.deltaTime, 0, 0);
        //¹æ¹ý2
        //var pos = transform.position;
        //pos.x += 
    }
}
