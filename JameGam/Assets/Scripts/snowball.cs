using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowball : MonoBehaviour
{
    public Vector2 target;
    float timer;
    // Start is called before the first frame update
    void Update()
    {
        if (timer >= 10)
        {
            Destroy(gameObject);
        }
        else
        {
            timer += Time.fixedDeltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Finish"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }else if (collision.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
