using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class TutorialManager : MonoBehaviour
{
    int cnt = 0;
    int txtCnt;
    [SerializeField] GameObject textBox;
    [SerializeField] List<string> texts;
    [SerializeField] TextMeshProUGUI tmp;
    [SerializeField] List<ReindeerController> rein;
    [SerializeField] float typingSpeed = 0.04f;
    private Coroutine displayLineCoroutine;
    bool enable;
    bool canContinue = false;

    private void Start()
    {
        txtCnt = 0;
    }
    private void Update()
    {
        if (enable)
        {
            if (Input.GetMouseButtonDown(0) && canContinue)
            {
                txtCnt++;
                if(txtCnt == texts.Count)
                {
                    foreach (var reindeer in rein)
                    {
                        reindeer.enabled = true;
                    }
                    enable = false;
                    textBox.gameObject.SetActive(false);
                    tmp.text = "";
                    return;
                }
                if (displayLineCoroutine != null)
                {
                    StopCoroutine(displayLineCoroutine);
                }
                displayLineCoroutine = StartCoroutine(displayLine(texts[txtCnt]));
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (txtCnt < texts.Count)
        {
            textBox.gameObject.SetActive(true);
            foreach (var reindeer in rein)
            {
                reindeer.enabled = false;
            }
            if(displayLineCoroutine != null)
            {
                StopCoroutine(displayLineCoroutine);
            }
            displayLineCoroutine = StartCoroutine(displayLine(texts[0]));
            enable = true;

        }
    }

    IEnumerator displayLine(string line)
    {
        tmp.text = line;
        tmp.maxVisibleCharacters = 0;
        canContinue = false;
        foreach(char letter in line.ToCharArray())
        {
            /*
            if (Input.GetMouseButtonDown(0))
            {
                tmp.maxVisibleCharacters = line.Length;
                break;
            }
            */
            tmp.maxVisibleCharacters++;
            yield return new WaitForSeconds(typingSpeed);
        }
        canContinue = true;
    }
}
