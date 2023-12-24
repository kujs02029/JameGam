using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BellGameManager : MonoBehaviour
{
    public List<int> clicked;
    public List<int> org;
    public List<GameObject> bells;
    public List<AudioSource> sounds;
    int c;
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i < 5; i++)
        {
            org.Add(Random.Range(1, 5));
        }
        Invoke("PlayNotes", 1);
    }

    void PlayNotes()
    {
        foreach(GameObject go in bells)
        {
            go.transform.localScale = new Vector3(2,2);
        }
        if(c!= 5)
        {

            bells[org[c] - 1].transform.localScale = new Vector3(2.5f, 2.5f, 1);
            sounds[org[c] - 1].Play();
            c++;
            return;
        }
        if(c <= 5)
        {
            Invoke("PlayNotes", 1);
        }
    }
    void Update()
    {
        if(clicked.Count == org.Count)
        {
            bool good = true;
            for (int i = 0; i < clicked.Count; i++)
            {
                if (clicked[i] != org[i])
                {
                    good = false;
                }
            }
            if (!good)
            {
                PlayerPrefs.SetFloat("S", 0);
                FindObjectOfType<CanvasAnim>().Fail();
            }
            else
            {
                PlayerPrefs.SetFloat("S", 1);
                FindObjectOfType<CanvasAnim>().Succeed();
            }
        }
    }

    
}
