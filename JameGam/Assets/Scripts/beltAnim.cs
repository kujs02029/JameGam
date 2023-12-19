using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beltAnim : MonoBehaviour
{
    private SpriteRenderer sp;
    private Sprite first;
    public Sprite second;
    public Sprite third;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        first = sp.sprite;
        Invoke("Next", .15f);
        sp.sprite = third;
    }

    void Next()
    {
        if (sp.sprite == first)
            sp.sprite = third;
        else if (sp.sprite == second)
            sp.sprite = first;
        else
            sp.sprite = second;
        Invoke("Next", .15f);
    }
}
