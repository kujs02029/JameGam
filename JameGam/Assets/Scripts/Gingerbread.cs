using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gingerbread : MonoBehaviour
{
    private GameObject player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Animator>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == player)
        {
            PlayerPrefs.SetFloat("S", 0);

            SceneManager.LoadScene(2);;
        }
    }
}
