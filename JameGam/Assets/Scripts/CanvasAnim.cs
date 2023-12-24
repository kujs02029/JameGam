using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasAnim : MonoBehaviour
{
    [SerializeField] Animator transition;
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
        StartCoroutine(SceneTransition(2));
    }
    public IEnumerator SceneTransition(int num)
    {
        transition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(num);
    }
}
