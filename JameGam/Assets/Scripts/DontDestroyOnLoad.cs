using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoad : MonoBehaviour
{
    int c = 0;
    public ReindeerController one;
    public ReindeerController two;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        c++;
        if(c > 1)
        {
            if(scene.buildIndex == 1)
            {
                if(PlayerPrefs.GetFloat("S") == 1)
                {
                    one.speed = 23.5f;
                    two.speed = 23.5f;
                }
                gameObject.SetActive(true);
                DontDestroyOnLoad[] dontDestroyOnLoads = new DontDestroyOnLoad[0];
                dontDestroyOnLoads = FindObjectsOfType<DontDestroyOnLoad>();
                for (int i = 0; i < dontDestroyOnLoads.Length; i++){
                    if (dontDestroyOnLoads[i] != this)
                    {
                        Destroy(dontDestroyOnLoads[i].gameObject);
                    }
                }
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
    private void OnDestroy()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
