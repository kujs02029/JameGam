using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elfSnowball : MonoBehaviour
{
    public GameObject snowball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject s = Instantiate(snowball, transform.position + new Vector3(0, 1), Quaternion.identity);
            s.GetComponent<snowball>().target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            s.GetComponent<Rigidbody2D>().AddForce((Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position).normalized * 20, ForceMode2D.Impulse);
        }
    }
}
