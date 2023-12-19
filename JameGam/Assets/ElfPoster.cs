using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfPoster : MonoBehaviour
{
    [SerializeField] Sprite[] elves;
    public int num;
    [SerializeField] SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 20);
        renderer.sprite = elves[num];
    }
}
