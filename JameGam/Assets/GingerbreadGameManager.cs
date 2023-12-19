using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GingerbreadGameManager : MonoBehaviour
{
    public GameObject gingerbread;

    private void Start()
    {
        
    }

    IEnumerator Spawn()
    {
        int a = Random.Range(0, 4);

        while (true)
        {
            if (a == 0)
                Instantiate(gingerbread, new Vector3(Random.Range(-8f, 8f), 7), Quaternion.identity);
            if (a == 1)
                Instantiate(gingerbread, new Vector3(Random.Range(-8f, 8f), -7), Quaternion.identity);
            if (a == 2)
                Instantiate(gingerbread, new Vector3(12, Random.Range(-4f, 4f)), Quaternion.identity);
            if (a == 3)
                Instantiate(gingerbread, new Vector3(-12, Random.Range(-4f, 4f)), Quaternion.identity);
            yield return new WaitForSeconds(3);
        }
    }
    void Update()
    {
        
    }
}
