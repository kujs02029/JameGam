using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class GingerbreadGameManager : MonoBehaviour
{
    public GameObject gingerbread;
    public List<Sprite> ginger;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {

        while (true)
        {
            GameObject b = null;
            int a = Random.Range(0, 6);
            if (a == 0)
            {
                 b = Instantiate(gingerbread, new Vector3(Random.Range(-8f, 8f), 7), Quaternion.identity);
            }
            if (a == 1)
            {
                 b = Instantiate(gingerbread, new Vector3(Random.Range(-8f, 8f), -7), Quaternion.identity);
            }
            if (a == 2)
            {

                b = Instantiate(gingerbread, new Vector3(12, Random.Range(-4f, 4f)), Quaternion.identity);
            }
                
            if (a == 3)
            {
                b = Instantiate(gingerbread, new Vector3(-12, Random.Range(-4f, 4f)), Quaternion.identity);
            }
            b.GetComponent<SpriteRenderer>().sprite = ginger[Random.Range(0, 3)];
            yield return new WaitForSeconds(3);
        }
    }
    void Update()
    {
        
    }
}
