using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Animator transition;
    public void Play()
    {
        StartCoroutine(SceneTransition());
        SceneManager.LoadScene(1);
    }
    public void Tutorial()
    {
        StartCoroutine(SceneTransition());
        SceneManager.LoadScene(11);
    }
    public void Main()
    {
        StartCoroutine(SceneTransition());
        SceneManager.LoadScene(0);
    }

    IEnumerator SceneTransition()
    {
        transition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
    }
}
