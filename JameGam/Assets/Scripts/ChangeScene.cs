using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<elfGingerMovement>())
        {
            SceneManager.LoadScene(2);;
        }
    }
}
