using UnityEngine;
using UnityEngine.EventSystems;

namespace SpriteChaser
{
    public class SettingsScreenHandler : MonoBehaviour
    {
        public GameObject BackButton;

        public void OnEnable()
        {
            EventSystem.current.SetSelectedGameObject(BackButton);
        }
    }
}