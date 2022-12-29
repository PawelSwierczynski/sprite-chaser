using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpriteChaser
{
    public class MainMenuController : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene((int)SceneIndex.Game);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}