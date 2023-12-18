using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private bool clicking;
    public string Type;

    private void OnMouseDrag()
    {
        print("asd");
        Vector2 ms = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(ms.x, ms.y, 0);
        clicking = true;
    }

    private void OnMouseUp()
    {
        clicking = false;
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        print(clicking);
        if (!clicking && collision.transform.CompareTag(Type))
        {
            Destroy(gameObject);
        }
    }
}
