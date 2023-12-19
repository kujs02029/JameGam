using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elfSnowball : MonoBehaviour
{
    int left;
    public int full;
    bool cans;
    public GameObject snowball;
    // Start is called before the first frame update
    void Start()
    {
        left = full;
        cans = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (cans)
            {
                left--;
                GameObject s = Instantiate(snowball, transform.position, Quaternion.identity);
                s.GetComponent<snowball>().target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                s.GetComponent<Rigidbody2D>().AddForce((Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized * 40, ForceMode2D.Impulse);
                if (left == 0)
                {
                    cans = false;
                    Invoke("Reload", 1.5f);
                }
            }
        }
    }

    void Reload()
    {
        cans = true;
        left = full;
    }
}
