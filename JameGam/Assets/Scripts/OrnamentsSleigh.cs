using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrnamentsSleigh : MonoBehaviour
{

    private void Update()
    {
        if (!FindObjectOfType<Ornaments>())
        {
            PlayerPrefs.SetFloat("S", 1);
            FindObjectOfType<CanvasAnim>().Succeed();
        }
    }
}
