using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Roof : MonoBehaviour
{
    public int num;
    public GameObject stop;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Elf")
        {
            //if(num == collision.gameObject.GetComponent<>())
            //{
                gameObject.SetActive(false);
            //}
        }else if(collision.transform.tag == "Player")
        {
            if(collision.gameObject.GetComponent<elfMovement>().num == num)
            {
                collision.gameObject.transform.position = stop.transform.position;
                SceneManager.LoadScene(2);;
            }
                
        }
    }
}
