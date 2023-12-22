using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skiHurdle : MonoBehaviour
{
    public float speed;
    public bool cos;
    public bool touch;
    private void Start()
    {
        Destroy(gameObject, 5);
    }
    private void OnDestroy()
    {
        if (!touch && !cos)
        {
            PlayerPrefs.SetFloat("S", 0);
            FindObjectOfType<CanvasAnim>().Fail();
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("ad");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        print("asd");
        if (collision.CompareTag("Player"))
        {
            print("Sui");
            touch = true;
        }
    }
}
