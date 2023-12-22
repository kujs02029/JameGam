using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLapCounter : MonoBehaviour
{
    int lap = 0;
    public int totalLap;
    public bool touched;
    public bool touched1;
    private void Start()
    {
        touched = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (touched && collision.CompareTag("GameController") && touched1)
        {
            touched = false;
            touched1 = false;
            lap++;
            print(lap + "/" + totalLap);
        }
    }
}
