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
            FindObjectOfType<CanvasAnim>().Succeed();
        }
        else
        {
            PlayerPrefs.SetFloat("S", 0);
            FindObjectOfType<CanvasAnim>().Succeed();
        }
    }
}
