using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonClicked : MonoBehaviour
{
    public void onClickLoad(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
