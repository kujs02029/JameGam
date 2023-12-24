using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class PlayerLapCounter : MonoBehaviour
{
    int lap = 0;
    public int totalLap;
    public bool touched;
    public bool touched1;
    [SerializeField] TextMeshProUGUI txt;
    [SerializeField] TextMeshProUGUI placeTxt;
    [SerializeField] GameObject PlaceScreen;
    int one;
    int two;
    int three;
    int place = 1;
    private void Start()
    {
        touched = true;
    }
    private void Update()
    {
        txt.text = lap + "/" + totalLap;
        if(lap == totalLap + 1)
        {
            PlaceScreen.SetActive(true);
            if(place == 1)
                placeTxt.text = "1st Place";
            else if (place == 2)
                placeTxt.text = "2nd Place";
            else if (place == 3)
                placeTxt.text = "3rd Place";
            else if (place == 4)
                placeTxt.text = "4th Place";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (touched && collision.CompareTag("GameController") && touched1)
        {
            touched = false;
            touched1 = false;
            lap++;
        }
        if (collision.CompareTag("1"))
        {
            one++;
            if(one > 3)
            {
                place++;
            }
        }
        if (collision.CompareTag("2"))
        {
            two++;
            if (two> 3)
            {
                place++;
            }
        }
        if (collision.CompareTag("3"))
        {
            three++;
            if (three > 3)
            {
                place++;
            }
        }
        
    }
}
