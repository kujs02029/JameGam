using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    public List<Follow> follows;
    public List<ReindeerController> rein;

    private void Start()
    {
        foreach (var follow in follows)
        {
            follow.enabled = false;
        }
        foreach (var reindeer in rein)
        {
            reindeer.enabled = false;
        }

        Invoke("StartRace", 3);
    }

    void StartRace()
    {
        foreach (var follow in follows)
        {
            follow.enabled = true;
        }
        foreach (var reindeer in rein)
        {
            reindeer.enabled = true;
        }
    }
}
