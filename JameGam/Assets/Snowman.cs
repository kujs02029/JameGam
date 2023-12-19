using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
    public float interval;
    public bool up;
    Vector2 start;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
        interval -= Random.Range(0, .5f);
        Invoke("goDown", interval);
    }

    void goUp()
    {
        up = true;
        transform.position += new Vector3(0, 1.5f);

        Invoke("goDown", interval);
        if(interval > 0.75f)
            interval -= Random.Range(0, .15f);
    }

    void goDown()
    {
        up = false;
        transform.position = start;

        Invoke("goUp", interval);
        if (interval > 0.25f)
            interval -= Random.Range(0, .15f);

    }
}
