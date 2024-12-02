using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject setting;
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void SettingButton()
    {
        setting.SetActive(true);
    }

    public void SettingButtonOut()
    {
        setting.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
