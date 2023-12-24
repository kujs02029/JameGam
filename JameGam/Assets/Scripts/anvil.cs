using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anvil : MonoBehaviour
{
    [SerializeField] anvilTrigger trigger;
    [SerializeField] Animator transition;
    int rand;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && trigger.entered == true)
        {
            StartCoroutine(SceneTransition(Random.Range(3,10)));
        }
    }
    public IEnumerator SceneTransition(int num)
    {
        transition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(num);
    }
}
