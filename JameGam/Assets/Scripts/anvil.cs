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
            rand = Random.Range(0, 8);
            if(rand == 0)
            {
                
            }
            else if(rand == 1)
            {

            }
            else if (rand == 2)
            {

            }
            else if (rand == 3)
            {

            }
            else if (rand == 4)
            {

            }
            else if (rand == 5)
            {

            }
            else if (rand == 6)
            {

            }
            else if (rand == 7)
            {

            }
            else if (rand == 8)
            {

            }
        }
    }
}
