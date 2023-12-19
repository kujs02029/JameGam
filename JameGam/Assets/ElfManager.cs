using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfManager : MonoBehaviour
{
    [SerializeField] Sprite[] elves;
    [SerializeField] ElfPoster poster;
    int[] nums = new int[20];
    bool all = false;
    int rand;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 20; i++)
        {
            nums[i] = 100;
        }
        nums[0] = poster.num;
        Debug.Log(poster.num);
        for(int i = 0; i < 20; i++)
        {
            if (!all)
            {
                rand = Random.Range(0, 20);
                for(int j = 0; j < 20; j++)
                {
                    if (nums[j] != rand)
                    {
                        nums[i] = rand;
                        Debug.Log(i);
                    }
                }
            }
            else
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (nums[4] != 100)
        {
            all = true;
        }
    }
}
