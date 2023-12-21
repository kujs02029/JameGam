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
            PlayerPrefs.SetFloat("S", 1);
        }
        else
            PlayerPrefs.SetFloat("S", 0);

        SceneManager.LoadScene(1);
    }
}
