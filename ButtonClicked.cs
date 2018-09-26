using System;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ButtonClicked : MonoBehaviour
{
    public GameObject parentPanel;

    GameController gameCon;

    void Start()
    {
        try
        {
            gameCon = GameObject.Find("Controller").GetComponent<GameController>();
        }
        catch (NullReferenceException nREx)
        {
            Debug.Log("GameObject with name Controller and/or Script named GameController is not present");
        }
    }

    public void onClickLoad(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void OnClickPause(bool pausedBool)
    {
        //A GameObject called Controller with a script called GameController is required to handle pausing

        gameCon.pauseManager(pausedBool);
    }

    public void onClickSwitchPanel(GameObject showPanel)
    {
        showPanel.SetActive(true);

        if (parentPanel != null)
        {
            parentPanel.SetActive(false);
        }
        else
        {
            Debug.Log("Parent panel not set");
        }
    }

    public void onClickExit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
