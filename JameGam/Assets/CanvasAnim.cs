using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasAnim : MonoBehaviour
{
    public void Succeed()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        Invoke("LoadScene", 1.5f);
    }
    public void Fail()
    {
        transform.GetChild(1).gameObject.SetActive(true);
        Invoke("LoadScene", 1.5f);
    }

    void LoadScene()
    {
        SceneManager.LoadScene(2);
    }
}
