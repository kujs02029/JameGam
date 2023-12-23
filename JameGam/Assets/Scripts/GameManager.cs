using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(11);
    }
    public void Main()
    {
        SceneManager.LoadScene(0);
    }
}
