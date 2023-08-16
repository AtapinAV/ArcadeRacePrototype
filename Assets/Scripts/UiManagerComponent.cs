using UnityEngine;
using UnityEngine.SceneManagement;

namespace Cars
{
    public class UiManagerComponent : MonoBehaviour
    {
        public void NewGame()
        {
            SceneManager.LoadScene("Cars");
        }

        public void PlayMenu()
        {
            SceneManager.LoadScene("Menu");
        }

        public void SettingMenu()
        {
            SceneManager.LoadScene("SettingAuto");
        }

        public void Exit()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE_WIN && !UNITY_EDITOR
            Application.Quit();
#endif
        }
    }
}


