using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ornaments : MonoBehaviour
{

    private void OnMouseDrag()
    {
        Vector2 ms = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(ms.x, ms.y, 0);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
