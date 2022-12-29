using UnityEngine;

namespace SpriteChaser
{
    public class SettingsKeyboardHandler : MonoBehaviour
    {
        public GameObject MainMenuScreen;
        public GameObject SettingsScreen;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                MainMenuScreen.SetActive(true);
                SettingsScreen.SetActive(false);
            }
        }
    }
}