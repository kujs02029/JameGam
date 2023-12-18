using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anvil : MonoBehaviour
{
    [SerializeField] anvilTrigger trigger;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && trigger.entered == true)
        {

        }
    }
}
