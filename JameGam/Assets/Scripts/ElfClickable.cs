using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElfClickable : MonoBehaviour
{
    public bool enm;
    private void OnMouseDown()
    {
        if (enm)
        {
            //Change scene;
        }
        else
            print("HA STUPID");
    }
}
