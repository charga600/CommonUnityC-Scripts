using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ButtonClicked : MonoBehaviour
{
    public GameObject parentPanel;

    public void onClickLoad(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
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
