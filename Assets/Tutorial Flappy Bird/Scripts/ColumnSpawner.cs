using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner: MonoBehaviour
{
    public GameObject column;
    public float delay = 3f;
    public float randomDelay = 2f;
    public float spawnX = 4;
    public float spawnYmin = -3;
    public float spawnYmax = 2.3f;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(true)
        {
            //3초 간격으로 배치, y값 랜덤으로 
            Vector3 pos;
            pos.x = spawnX;
            pos.y = Random.Range(spawnYmin, spawnYmax);
            pos.z = 0;
            Instantiate(column, pos, column.transform.rotation);


            //스폰 시키는 x값은 고정값으로 ! 
            yield return new WaitForSeconds(delay + Random.Range(-randomDelay, +randomDelay));

        }


    }
}
