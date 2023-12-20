using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfPoster : MonoBehaviour
{
    public int num;
    [SerializeField] SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 20);

    }
}
