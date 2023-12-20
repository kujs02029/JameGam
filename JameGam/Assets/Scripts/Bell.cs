using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour
{
    public int num;
    private void OnMouseDown()
    {
        FindObjectOfType<BellGameManager>().clicked.Add(num);
    }


}
