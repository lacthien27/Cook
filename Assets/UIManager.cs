using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEditor;
public class UIManager : ThienMonoBehaviour
{
 //   public enum UIPanel { Menu, Mode, None }

    public GameObject menuUI;

    public GameObject modeUI;

    public GameObject layoutUI;


    protected override void LoadComponents()
    {
        base.LoadComponents();
    }
    protected override void Awake()
    {
        base.Awake();
        this.hideAllUI();
    }

    public void OnRestartButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        this.hideAllUI();
    }

    public void OnResumeButtonClicked()
    {
        this.hideAllUI();
    }

    public void OnChangeModeButtonClicked()
    {
        this.ShowModeUI();
    }

    public void OnExitButtonClicked()
    {
        this.ShowMenuUI();
    }

    public void OnPauseButtonClicked()
    {
        this.ShowMenuUI();
    }

    public void hideAllUI()
    {
        layoutUI.SetActive(false);
        menuUI.SetActive(false);
        modeUI.SetActive(false);
    }

    public void ShowMenuUI()
    {
        layoutUI.SetActive(true);
        menuUI.SetActive(true);
        modeUI.SetActive(false);

    }

    public void ShowModeUI()
    {
        layoutUI.SetActive(true);
        modeUI.SetActive(true);
        menuUI.SetActive(false);

    }

/**
    public void ShowUI(UIPanel type)
    {
        hideAllUI();
        layoutUI.SetActive(true);

        switch (type)
        {
            case UIPanel.Menu:
                menuUI.SetActive(true);
                break;
            case UIPanel.Mode:
                modeUI.SetActive(true);
                break;
            default:
                break;
        }
    }
    **/
}