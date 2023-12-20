using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BellGameManager : MonoBehaviour
{
    public List<int> clicked;
    public List<int> org;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 8; i++)
        {
            org.Add(Random.Range(1, 5));
        }
    }

    // Update is called once per frame
    void Update()
    {
        bool good = false;
        if(clicked.Count == org.Count)
        {
            for(int i = 0; i < clicked.Count; i++)
            {
                if (clicked[i] == org[i])
                {
                    good = true;
                }
            }
        }
        if (good)
        {
            //Change Scene
        }
    }
}
