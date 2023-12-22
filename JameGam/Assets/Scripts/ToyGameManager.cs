using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToyGameManager : MonoBehaviour
{
    public List<GameObject> toys;
    public float interval;
    public int toy;
    private int c;
    // Start is called before the first frame update
    void Start()
    {
        SpawnToys();
    }

    void SpawnToys()
    {
        if(toy == c)
        {
            PlayerPrefs.SetFloat("S", 1);

            FindObjectOfType<CanvasAnim>().Succeed();
        }
        c++;
        Instantiate(toys[Random.Range(0, toys.Count)], new Vector2(-16, 7), Quaternion.identity);
        Invoke("SpawnToys", interval);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Toys>())
            Destroy(collision.gameObject, 1f);
        if (collision.GetComponent<Toys>().bad)
        {
            PlayerPrefs.SetFloat("S", 0);
            FindObjectOfType<CanvasAnim>().Fail();
        }
    }
}
