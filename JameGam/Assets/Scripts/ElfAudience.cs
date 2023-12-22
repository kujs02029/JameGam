using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfAudience : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float rotationModifier;
    private void Start()
    {
        transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = GetComponent<SpriteRenderer>().sprite;
        EnemySleigh[] sl = FindObjectsOfType<EnemySleigh>();
        player = sl[Random.Range(0, sl.Length)].gameObject;
    }
    private void FixedUpdate()
    {
        if (player != null)
        {
            Vector3 vectorToTarget = player.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - rotationModifier;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
        }
    }
}
