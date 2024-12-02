using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    [SerializeField] private Text dialogText;
    [SerializeField] private TextMeshProUGUI dialogName;
    [SerializeField] private float lettersPerSecond;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject gameEnd;
    [SerializeField] private GameObject ThisCanvas;

    private bool isTyping;
    private int currentLine = 0;
    private int diaTurn = 0;
    public int pass = 2;
    private string names;
    private bool win = false;
    [SerializeField] private Image img;

    [Header("Dialog1")]
    [SerializeField] public Dialog dialog1;
    [SerializeField] private Dialog dialog2;
    [SerializeField] private Dialog dialog3;
    [SerializeField] private Dialog dialog4;
    [SerializeField] private Dialog dialog5;
    [SerializeField] private Dialog dialog6;
    [SerializeField] private Dialog dialog7;
    [SerializeField] private Dialog dialog8;
    [SerializeField] private Dialog dialogChoose;
    [SerializeField] public GameObject choose1;

    [Header("Dialog2")]
    [SerializeField] private GameObject bg1;
    [SerializeField] private GameObject bg2;
    [SerializeField] private GameObject bg1p;
    [SerializeField] private GameObject bg2p;
    [SerializeField] public Dialog dialog11;
    [SerializeField] private Dialog dialog21;
    [SerializeField] private Dialog dialog31;
    [SerializeField] private Dialog dialog41;
    [SerializeField] private Dialog dialog51;
    [SerializeField] private Dialog dialog61;
    [SerializeField] private Dialog dialog71;
    [SerializeField] private Dialog dialog81;
    [SerializeField] private Dialog dialog91;
    [SerializeField] public GameObject choose2;
    [SerializeField] private Dialog dialog12;
    [SerializeField] private Dialog dialog13;
    [SerializeField] public GameObject choose3;
    [SerializeField] private Dialog dialog14;
    [SerializeField] private Dialog dialog15;
    [SerializeField] private Dialog dialog16;
    [SerializeField] private Dialog dialog17;
    [SerializeField] private Dialog dialog18;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isTyping && !win)
        {
            if (diaTurn == 0)
            {
                img.color = new Color(255, 255, 255, 1);
                Dialog(dialog1.img, dialog1.names, dialog1.lines);
            }
            else if (diaTurn == 1)
            {
                Dialog(dialog2.img, dialog2.names, dialog2.lines);
            }
            else if (diaTurn == 2)
            {
                Dialog(dialog3.img, dialog3.names, dialog3.lines);
            }
            else if (diaTurn == 3)
            {
                Dialog(dialog4.img, dialog4.names, dialog4.lines);
            }
            else if (diaTurn == 4)
            {
                Dialog(dialog5.img, dialog5.names, dialog5.lines);
            }
            else if (diaTurn == 5)
            {
                Dialog(dialog6.img, dialog6.names, dialog6.lines);
            }
            else if (diaTurn == 6)
            {
               Choose(dialogChoose.img, dialogChoose.names, dialogChoose.lines, choose1);
            }
            else if (diaTurn == 8 && pass == 0)
            {
                EndGame(dialog7.img, dialog7.names, dialog7.lines);
            }
            else if (diaTurn == 8 && pass == 1)
            {
                Dialog(dialog8.img, dialog8.names, dialog8.lines);
            }
            else if (diaTurn == 9)
            {
                bg1.SetActive(false);
                bg2.SetActive(true);
                bg1p.SetActive(false);
                bg2p.SetActive(true);
                img.color = new Color(255, 255, 255, 0);
                ShortDialog(dialog8.img, "", "");
            }
            else if (diaTurn == 10)
            {
                img.color = new Color(255, 255, 255, 1);
                Dialog(dialog11.img, dialog11.names, dialog11.lines);
            }
            else if (diaTurn == 11)
            {
                Dialog(dialog21.img, dialog21.names, dialog21.lines);
            }
            else if (diaTurn == 12)
            {
                Dialog(dialog31.img, dialog31.names, dialog31.lines);
            }
            else if (diaTurn == 13)
            {
                Dialog(dialog41.img, dialog41.names, dialog41.lines);
            }
            else if (diaTurn == 14)
            {
                Dialog(dialog51.img, dialog51.names, dialog51.lines);
            }
            else if (diaTurn == 15)
            {
                Dialog(dialog61.img, dialog61.names, dialog61.lines);
            }
            else if (diaTurn == 16)
            {
                Dialog(dialog71.img, dialog71.names, dialog71.lines);
            }
            else if (diaTurn == 17)
            {
                Dialog(dialog81.img, dialog81.names, dialog81.lines);
            }
            else if (diaTurn == 18)
            {
                Dialog(dialog91.img, dialog91.names, dialog91.lines);
            }
            else if (diaTurn == 19)
            {
                Choose(dialogChoose.img, dialogChoose.names, dialogChoose.lines, choose2);
            }
            else if (diaTurn == 21 && pass == 0)
            {
                EndGame(dialog12.img, dialog12.names, dialog12.lines);
            }
            else if (diaTurn == 21 && pass == 1)
            {
                Dialog(dialog13.img, dialog13.names, dialog13.lines);
            }
            else if (diaTurn == 22)
            {
                Choose(dialogChoose.img, dialogChoose.names, dialogChoose.lines, choose3);
            }
            else if (diaTurn == 24 && pass == 0)
            {
                EndGame(dialog14.img, dialog14.names, dialog14.lines);
            }
            else if (diaTurn == 24 && pass == 1)
            {
                Dialog(dialog15.img, dialog15.names, dialog15.lines);
            }
            else if (diaTurn == 25)
            {
                Dialog(dialog16.img, dialog16.names, dialog16.lines);
            }
            else if (diaTurn == 26)
            {
                Dialog(dialog17.img, dialog17.names, dialog17.lines);
            }
            else if (diaTurn == 27)
            {
                Dialog(dialog18.img, dialog18.names, dialog18.lines);
            }
            else if (diaTurn == 28)
            {
                win = true;
                End();
            }
        }
    }

    public IEnumerator TypeDialog(string line)
    {
        isTyping = true;
        dialogText.text = "";
        foreach (var letter in line.ToCharArray())
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(1 / lettersPerSecond);
        }
        isTyping = false;
    }

    public void Dialog(Sprite imgs, string name, List<string> line)
    {
        img.sprite = imgs;
        names = name;
        dialogName.text = names;
        if (currentLine < line.Count)
        {
            StartCoroutine(TypeDialog(line[currentLine]));
            ++currentLine;
        }
        if (currentLine == line.Count)
        {
            currentLine = 0;
            diaTurn++;
        }
    }

    public void ShortDialog(Sprite imgs, string name, string line)
    {
        img.sprite = imgs;
        names = name;
        dialogName.text = names;
        StartCoroutine(TypeDialog(line));
        ++currentLine;
        currentLine = 0;
        diaTurn++;
    }

    public void Choose(Sprite imgs, string name, List<string> line, GameObject choose)
    {
        img.sprite = imgs;
        names = name;
        dialogName.text = names;
        choose.SetActive(true);
        if (currentLine < line.Count)
        {
            StartCoroutine(TypeDialog(line[currentLine]));
            ++currentLine;
        }
        if (currentLine == line.Count)
        {
            currentLine = 0;
            diaTurn++;
            pass = 2;
        }
    }

    public void EndGame(Sprite imgs, string name, List<string> line)
    {
        img.sprite = imgs;
        names = name;
        dialogName.text = names;
        if (currentLine < line.Count)
        {
            StartCoroutine(TypeDialog(line[currentLine]));
            ++currentLine;
        }
        if (currentLine == line.Count)
        {
            Invoke(nameof(Die), 2);
        }
    }

    private void Die()
    {
        gameOver.SetActive(true);
    }

    private void End()
    {
        ThisCanvas.SetActive(false);
        gameEnd.SetActive(true);
    }
}
