using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SleighManager : MonoBehaviour
{
    [SerializeField] GameObject circle;
    [SerializeField] List<Color> colors;
     Reindeer[] reindeers;
    [SerializeField] List<Sprite> Rsprites;
    [SerializeField] List<Sprite> sleighs;
    [SerializeField] List<Sprite> roofs;
    // Start is called before the first frame update
    void Start()
    {
        reindeers = FindObjectsOfType<Reindeer>();
        EnemySleigh[] sleighs_ = FindObjectsOfType<EnemySleigh>();
        foreach (EnemySleigh r in sleighs_)
        {
            SpriteRenderer a = r.transform.GetChild(1).GetComponent<SpriteRenderer>();
            SpriteRenderer d = r.transform.GetChild(0).GetChild(0).GetComponent<Reindeer>().roof;
            SpriteRenderer c = r.transform.GetChild(1).GetChild(1).GetComponent<SpriteRenderer>();

            int b = Random.Range(0, sleighs.Count);
            c.color = colors[b];
            a.sprite = sleighs[b];
            d.sprite = roofs[b];
            colors.RemoveAt(b);
            roofs.RemoveAt(b);
            sleighs.RemoveAt(b);
        }
        foreach (var reindeer in reindeers)
        {

            int a = Random.Range(0, Rsprites.Count);
            reindeer.gameObject.GetComponent<SpriteRenderer>().sprite = Rsprites[a];
            Rsprites.RemoveAt(a);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
