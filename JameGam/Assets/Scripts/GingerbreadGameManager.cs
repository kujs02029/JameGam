using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;

public class GingerbreadGameManager : MonoBehaviour
{
    public GameObject gingerbread;
    private float count;
    public List<Sprite> ginger;
    public float rate = 3;
    int c;
    private void Start()
    {
        count = Random.Range(5, 8);
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {

        while (true)
        {
            if (count > c)
            {
                c++;
                GameObject b = null;
                int a = Random.Range(0, 4);
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
                b.GetComponent<SpriteRenderer>().sprite = ginger[Random.Range(0, 6)];
                yield return new WaitForSeconds(rate);
            }
            else
            {
                SceneManager.LoadScene(2);
                PlayerPrefs.SetFloat("S", 1);
                break;
            }

        }
    }
}
