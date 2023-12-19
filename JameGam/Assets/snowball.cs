using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowball : MonoBehaviour
{
    public Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Vector2.Distance(target, transform.position));
        if(Vector2.Distance(target, transform.position) < 1f)
        {
            Destroy(gameObject);
        }
    }
}
