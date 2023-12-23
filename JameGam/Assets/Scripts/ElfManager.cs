using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfManager : MonoBehaviour
{
    [SerializeField] GameObject elf;
    [SerializeField] GameObject elfF;
    [SerializeField] List<Sprite> elves;
    [SerializeField] List<Sprite> elfN;
    [SerializeField] ElfPoster poster;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++) {
            elfN.Add(elves[Random.Range(0, 20-i)]);
            elves.Remove(elfN[i]);
            GameObject e = Instantiate(elf, new Vector3(Random.Range(-8f, 4), Random.Range(-3f, 1.7f)), Quaternion.identity);
            e.GetComponent<SpriteRenderer>().sprite = elfN[i];
            if (i == 0)
                e.GetComponent<ElfClickable>().enm = true;
        }

        elfF.GetComponent<SpriteRenderer>().sprite = elfN[0];
    }

}
