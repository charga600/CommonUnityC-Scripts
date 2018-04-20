using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;

public class ButtonClicked : MonoBehaviour
{
    public void onClickLoad(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
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
