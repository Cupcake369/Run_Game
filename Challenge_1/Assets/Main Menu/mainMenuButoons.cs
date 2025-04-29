using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenuButoons : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Challenge_1");
    }

    public void OnExitClick() 
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

}
