using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseEvent : MonoBehaviour
{
    [SerializeField] private DialogManager dialogManager;
    public void GameOver()
    {
        dialogManager.pass = 0;
        dialogManager.choose1.SetActive(false);
        dialogManager.ShortDialog(dialogManager.dialog1.img, dialogManager.dialog1.names, "Chỉ có đàn ông mới đem lại hạnh phúc cho nhau");

    }

    public void GameOver1()
    {
        dialogManager.pass = 0;
        dialogManager.choose2.SetActive(false);
        dialogManager.ShortDialog(dialogManager.dialog1.img, dialogManager.dialog1.names, "Không");

    }

    public void GameOver2()
    {
        dialogManager.pass = 0;
        dialogManager.choose3.SetActive(false);
        dialogManager.ShortDialog(dialogManager.dialog1.img, dialogManager.dialog1.names, "Thà chết còn hơn làm nô lệ");

    }

    public void Pass()
    {
        dialogManager.pass = 1;
        dialogManager.choose1.SetActive(false);
        dialogManager.ShortDialog(dialogManager.dialog1.img, dialogManager.dialog1.names, "Tôi làm gì đâu mà mấy anh nóng thế");
    }

    public void Pass1()
    {
        dialogManager.pass = 1;
        dialogManager.choose2.SetActive(false);
        dialogManager.ShortDialog(dialogManager.dialog1.img, dialogManager.dialog1.names, "Có chứ, tôi mà không thì tôi chết à?");
    }

    public void Pass2()
    {
        dialogManager.pass = 1;
        dialogManager.choose3.SetActive(false);
        dialogManager.ShortDialog(dialogManager.dialog1.img, dialogManager.dialog1.names, "Tôi xin bán mình cho tư bản");
    }
}
