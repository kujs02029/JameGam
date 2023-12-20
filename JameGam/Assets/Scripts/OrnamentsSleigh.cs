using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        //change scene
    }
}
