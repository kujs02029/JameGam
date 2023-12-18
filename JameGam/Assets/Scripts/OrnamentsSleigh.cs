using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrnamentsSleigh : MonoBehaviour
{
    bool col;
    private void OnTriggerStay2D(Collider2D collision)
    {
        col = true;
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        col = false;
    }
}
