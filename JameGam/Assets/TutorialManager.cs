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
    bool enable;

    private void Start()
    {
        txtCnt = 0;
    }
    private void Update()
    {
        if (enable)
        {
            if (Input.GetMouseButtonDown(0))
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
                tmp.text = texts[txtCnt];
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
            tmp.text = texts[0];
            enable = true;

        }
    }
}
