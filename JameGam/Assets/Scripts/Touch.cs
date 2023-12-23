using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public bool one;
    public bool no;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GameController"))
        {
            if (one)
            {
                FindObjectOfType<PlayerLapCounter>().touched1 = true;
            }
            else
            {
                FindObjectOfType<PlayerLapCounter>().touched = true;
            }
        }
    }
}
