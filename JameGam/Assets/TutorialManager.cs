using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialManager : MonoBehaviour
{
    int cnt = 0;
    int txtCnt;
    [SerializeField] GameObject textBox;
    [SerializeField] List<string> texts;
    [SerializeField] TextMeshProUGUI tmp;
    [SerializeField] List<ReindeerController> rein;

    private void Start()
    {
        txtCnt = 3;
        nextText();
    }
    public void nextText()
    {
        foreach (var reindeer in rein)
        {
            reindeer.enabled = false;
        }
        textBox.SetActive(true);
        for(int i = 0; i < txtCnt;)
        {
            if (Input.GetMouseButtonDown(0))
            {
                tmp.text = texts[i];
                texts.RemoveAt(i);
            }
        }
        cnt++;
        foreach (var reindeer in rein)
        {
            reindeer.enabled = true;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (cnt == 1)
        {
            txtCnt = 2;
            textBox.SetActive(false);
        }
        else if (cnt == 2)
        {
            txtCnt = 2;
            textBox.SetActive(false);
        }
        nextText();
    }
}
