using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfGenerator : MonoBehaviour
{
    public List<Sprite> elfTop;
    public GameObject elf;
    public int count;
    [SerializeField] List<BoxCollider2D> bc;
    private Transform parent;
    Vector2 cubeSize;
    Vector2 cubeCenter;


    private void Awake()
    {
        parent = transform.parent;
    }




    private Vector2 GetRandomPosition()
    {
        // You can also take off half the bounds of the thing you want in the box, so it doesn't extend outside.
        // Right now, the center of the prefab could be right on the extents of the box
        Vector2 randomPosition = new Vector2(Random.Range(-cubeSize.x/2, cubeSize.x/2), Random.Range(-cubeSize.y/2 , cubeSize.y/2));

        return cubeCenter + randomPosition;
    }

    void Start()
    {
        //make elf look at sleighs
        for (int i = 0; i < count; i++)
        {

            int a = Random.Range(0, 8);
            Transform cubeTrans = bc[a].GetComponent<Transform>();
            cubeCenter = cubeTrans.position;
            cubeSize.x = cubeTrans.localScale.x * bc[a].size.x;
            cubeSize.y = cubeTrans.localScale.y * bc[a].size.y;
            GameObject b = Instantiate(elf, GetRandomPosition(), Quaternion.identity);
            b.GetComponent<SpriteRenderer>().sprite = elfTop[Random.Range(0, elfTop.Count)];
            b.transform.SetParent(parent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
