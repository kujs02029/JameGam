using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreeManager : MonoBehaviour
{
    [SerializeField] bar br;
    public int health = 100;
    int c = 0;
    public GameObject s;
    public GameObject s1;
    public GameObject s2;
    public void damageTree()
    {
        if(br.gameObject.transform.position.y > 0)
        {
            int damage = Random.Range(40, 60);
            health -= damage;
        }
        else if(br.gameObject.transform.position.y > 1)
        {
            int damage = Random.Range(25, 45);
            health -= damage;
        }
        else if (br.gameObject.transform.position.y > 1)
        {
            int damage = Random.Range(15, 35);
            health -= damage;
        }
        else if (br.gameObject.transform.position.y > 1)
        {
            int damage = Random.Range(5, 20);
            health -= damage;
        }
        c++;
        Invoke("stopI", 1);
    }

    void stopI()
    {
        br.stop = false;
    }
    private void Update()
    {
        if(c == 1)
        {
            s.GetComponent<SpriteRenderer>().color = Color.black;
        }if( c== 2)
        {
            s1.GetComponent<SpriteRenderer>().color = Color.black;

        }
        if (c == 3)
        {
            s2.GetComponent<SpriteRenderer>().color = Color.black;

        }
        if (health <= 0)
        {
            


            PlayerPrefs.SetFloat("S", 1);
            FindObjectOfType<CanvasAnim>().Succeed();
        }
        if (c == 4)
        {
            FindObjectOfType<CanvasAnim>().Fail();
            PlayerPrefs.SetFloat("S", 0);
        }
    }
}
