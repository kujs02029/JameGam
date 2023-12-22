using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLapCounter : MonoBehaviour
{
    int lap = 0;
    public int totalLap;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            lap++;
            print(lap + "/" + totalLap);
        }
    }
}
