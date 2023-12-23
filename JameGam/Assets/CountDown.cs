using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public GameObject gamemanager;
    public List<string> texts;
    public TextMeshProUGUI tm;
    // Start is called before the first frame update
    void Start()
    {
        gamemanager.SetActive(false);
        Invoke("Restart", 3);
        tm.text = texts[SceneManager.GetActiveScene().buildIndex];
    }

    void Restart()
    {
        gamemanager.SetActive(true);
        tm.text = "";
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
