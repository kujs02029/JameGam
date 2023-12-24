using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Animator transition;
    public void Play(int num)
    {
        StartCoroutine(SceneTransition(num));
    }
    IEnumerator SceneTransition(int num)
    {
        print("asd");
        transition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(num);
    }
}
