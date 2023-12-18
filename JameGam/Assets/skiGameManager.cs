using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skiGameManager : MonoBehaviour
{
    public GameObject hurdle;
    public float interval;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnHurdle", interval);
    }
    private void Update()
    {

        float v = Input.GetAxis("Vertical");

        if (v < 0)
        {
            interval = 1.5f;
        }
        else
        {
            interval = 2;
        }
    }
    void SpawnHurdle()
    {
        Instantiate(hurdle, new Vector2(Random.Range(-5f, 5f), -8), Quaternion.identity);
        Invoke("SpawnHurdle", interval);
    }
}
