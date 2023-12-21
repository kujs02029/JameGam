using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skiHurdle : MonoBehaviour
{
    public float speed;
    public bool cos;
    bool touch;
    private void Start()
    {
        Destroy(gameObject, 5);
    }
    private void OnDestroy()
    {
        if (!touch && !cos)
        {
            PlayerPrefs.SetFloat("S", 0);
            SceneManager.LoadScene(1);
        }
    }
    private void Update()
    {
        float v = Input.GetAxis("Vertical");

        if(v< 0)
        {
            speed = 8;
        }
        else
        {
            speed = 5;
        }
    }
    void FixedUpdate()
    {
        transform.position += new Vector3(0, speed) * Time.fixedDeltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            touch = true;
        }
    }
}
