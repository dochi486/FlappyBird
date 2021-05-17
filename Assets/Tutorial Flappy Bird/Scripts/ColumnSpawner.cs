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
            //3�� �������� ��ġ, y�� �������� 
            Vector3 pos;
            pos.x = spawnX;
            pos.y = Random.Range(spawnYmin, spawnYmax);
            pos.z = 0;
            Instantiate(column, pos, column.transform.rotation);


            //���� ��Ű�� x���� ���������� ! 
            yield return new WaitForSeconds(delay + Random.Range(-randomDelay, +randomDelay));

        }


    }
}
