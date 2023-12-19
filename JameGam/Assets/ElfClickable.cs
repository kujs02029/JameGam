using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfClickable : MonoBehaviour
{
    public bool enm;
    private void OnMouseDown()
    {
        if (enm)
        {
            print("You did it stupid");
        }
        else
            print("HA STUPID");
    }
}
