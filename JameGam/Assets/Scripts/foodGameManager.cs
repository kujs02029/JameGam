using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodGameManager : MonoBehaviour
{
    public List<GameObject> foods;
    public List<GameObject> slots;
    public List<string> types;
    public List<Sprite> sprites;
    void Start()
    {
        for(int i = 0; i < 6; i++)
        {
            Instantiate(foods[Random.Range(0, foods.Count)], new Vector2(Random.Range(-8f, 8f), Random.Range(-4, -1)), Quaternion.identity);
        }
        
        for (int i = 0;i < slots.Count; i++)
        {
            int a = Random.Range(0, types.Count);
            slots[i].tag = types[a];
            slots[i].transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = sprites[a];
            sprites.RemoveAt(a);
            types.RemoveAt(a);
        }
    }
}
