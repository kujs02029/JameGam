using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyGameManager : MonoBehaviour
{
    public List<GameObject> toys;
    public float interval;
    // Start is called before the first frame update
    void Start()
    {
        SpawnToys();
    }

    void SpawnToys()
    {
        Instantiate(toys[Random.Range(0, toys.Count)], new Vector2(-16, 7), Quaternion.identity);
        Invoke("SpawnToys", interval);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Toys>())
            Destroy(collision.gameObject, 1f);
        if (collision.GetComponent<Toys>().bad)
        {
            print("DEATH");
        }
    }
}
