using UnityEngine;
using UnityEngine.EventSystems;

namespace SpriteChaser
{
    public class MainMenuScreenHandler : MonoBehaviour
    {
        public GameObject StartButton;

        public void OnEnable()
        {
            EventSystem.current.SetSelectedGameObject(StartButton);
        }
    }
}