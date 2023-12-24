using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Roof : MonoBehaviour
{
    public int num;
    public GameObject stop;
    [SerializeField] Animator transition;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Elf")
        {
            //if(num == collision.gameObject.GetComponent<>())
            //{
                gameObject.SetActive(false);
            //}
        }else if(collision.transform.tag == "Player")
        {
            if(collision.gameObject.GetComponent<elfMovement>().num == num)
            {
                collision.gameObject.transform.position = stop.transform.position;
                StartCoroutine(SceneTransition());
                SceneManager.LoadScene(2);
            }
                
        }
    }

    public IEnumerator SceneTransition()
    {
        transition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
    }
}
