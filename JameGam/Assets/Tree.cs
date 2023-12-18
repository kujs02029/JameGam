using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public List<Sprite> s;
    private SpriteRenderer sp;
    private TreeManager treeManager;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        treeManager = FindObjectOfType<TreeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (treeManager.health < 20)
        {
            sp.sprite = s[4];
        }
        else if (treeManager.health < 40)
        {
            sp.sprite = s[3];
        }
        else if (treeManager.health < 60)
        {
            sp.sprite = s[2];
        }
        else if (treeManager.health < 80)
        {
            sp.sprite = s[1];
        }
        else if (treeManager.health < 100)
        {
            sp.sprite = s[0];
        }
    }
}
