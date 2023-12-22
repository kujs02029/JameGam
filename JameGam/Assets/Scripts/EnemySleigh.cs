using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySleigh : MonoBehaviour
{
    public float health;
    public float maxHealth;
    private Follow follow;
    public float maxSpeed;
    public float minSpeed;
    public float safe;
    // 1 ~ 5
    // Start is called before the first frame update
    void Start()
    {
        follow = GetComponent<Follow>();
    }

    // Update is called once per frame
    void Update()
    {
        follow.MovementSpeed = (health / maxHealth) * maxSpeed > minSpeed ? (health / maxHealth) * maxSpeed : minSpeed;
        if(health <= maxHealth / safe)
        {
            follow.goIn = true;
        }
    }
}
