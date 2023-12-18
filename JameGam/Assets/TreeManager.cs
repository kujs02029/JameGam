using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
    [SerializeField] bar br;
    int health = 100;

    public void damageTree()
    {
        if(br.gameObject.transform.position.y > 0)
        {
            health -= 50;
        }
        else if(br.gameObject.transform.position.y > 1)
        {
            health -= 35;
        }
        else if (br.gameObject.transform.position.y > 1)
        {
            health -= 25;
        }
        else if (br.gameObject.transform.position.y > 1)
        {
            health -= 10;
        }
        br.stop = false;
    }
    private void Update()
    {
        if (health <= 0)
        {

        }
    }
}
