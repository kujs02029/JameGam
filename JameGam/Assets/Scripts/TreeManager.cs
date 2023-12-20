using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreeManager : MonoBehaviour
{
    [SerializeField] bar br;
    public int health = 100;

    public void damageTree()
    {
        print(health);
        if(br.gameObject.transform.position.y > 0)
        {
            health -= Random.Range(40, 60);
        }
        else if(br.gameObject.transform.position.y > 1)
        {
            health -= Random.Range(25, 45);
        }
        else if (br.gameObject.transform.position.y > 1)
        {
            health -= Random.Range(15, 35);
        }
        else if (br.gameObject.transform.position.y > 1)
        {
            health -= Random.Range(5, 20);
        }
        Invoke("stopI", 1);
    }

    void stopI()
    {
        br.stop = false;
    }
    private void Update()
    {
        if (health <= 0)
        {
            //change scene
        }
    }
}
