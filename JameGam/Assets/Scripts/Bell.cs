using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour
{
    public int num;
    private void OnMouseDown()
    {
        FindObjectOfType<BellGameManager>().clicked.Add(num);
        transform.localScale += Vector3.one;
        Invoke("Normal", .5f);
    }
    void Normal()
    {
        transform.localScale = new Vector2(2, 2);
    }


}
