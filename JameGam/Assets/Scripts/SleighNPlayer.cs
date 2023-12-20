using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SleighNPlayer : MonoBehaviour
{
    public bool isOnSleigh;
    [SerializeField] GameObject elf;
    [SerializeField] GameObject landingPlace;
    [SerializeField] CameraFollow CF;
    [SerializeField] GameObject FP;
    
    [SerializeField] anvilTrigger aT;
    [SerializeField] GameObject topView;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && aT.entered)
        {
            topView.SetActive(true);
            isOnSleigh = true;
            CF.target = FP.transform;
            elf.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E)) {
            topView.SetActive(false);
            isOnSleigh = false;
            elf.transform.position = landingPlace.transform.position;
            elf.SetActive(true);
            CF.target = elf.transform;
        }
    }
}
