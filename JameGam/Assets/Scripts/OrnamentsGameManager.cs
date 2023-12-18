using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrnamentsGameManager : MonoBehaviour
{
    public List<GameObject> ornaments;
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            Instantiate(ornaments[Random.Range(0, ornaments.Count)], new Vector2(Random.Range(-4f, 4f), Random.Range(-1.5f, 1.5f)), Quaternion.identity);
        }

    }


}
