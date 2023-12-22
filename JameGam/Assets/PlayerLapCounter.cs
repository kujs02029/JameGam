using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerLapCounter : MonoBehaviour
{
    int lap = 1;
    public int totalLap;
    public bool touched;
    public bool touched1;
    [SerializeField] TextMeshProUGUI txt;
    private void Start()
    {
        touched = true;
    }
    private void Update()
    {
        txt.text = lap + "/" + totalLap;
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
