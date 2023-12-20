using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anvilTrigger : MonoBehaviour
{
    [SerializeField] GameObject press;
    public bool entered = false;
    public bool anvil;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        press.SetActive(true);
        entered = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        press.SetActive(false);
        entered = false;
    }
}
