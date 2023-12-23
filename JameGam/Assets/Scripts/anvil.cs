using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anvil : MonoBehaviour
{
    [SerializeField] anvilTrigger trigger;
    int rand;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && trigger.entered == true)
        {
            SceneManager.LoadScene(Random.Range(3, 11));
        }
    }
}
