using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] Animator transition;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<elfGingerMovement>())
        {
            StartCoroutine(SceneTransition(1));
        }
    }
    public IEnumerator SceneTransition(int num)
    {
        transition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(num);
    }
}
