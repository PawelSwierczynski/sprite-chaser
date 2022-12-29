using UnityEngine;

namespace SpriteChaser
{
    public class RunAwayController : MonoBehaviour
    {
        private GameObject player;

        public void Start()
        {
            player = FindObjectOfType<GameKeyboardHandler>().gameObject;
        }

        public void Update()
        {
            var positionChange = (transform.position - player.transform.position) * Time.deltaTime * 0.1f;
            var newPosition = transform.position + positionChange;

            if (newPosition.x < ScreenSize.GameLeftScreenThreshold)
            {
                newPosition.x = ScreenSize.GameLeftScreenThreshold;
            }
            else if (newPosition.x > ScreenSize.GameRightScreenThreshold)
            {
                newPosition.x = ScreenSize.GameRightScreenThreshold;
            }

            if (newPosition.y < ScreenSize.GameBottomScreenThreshold)
            {
                newPosition.y = ScreenSize.GameBottomScreenThreshold;
            }
            else if (newPosition.y > ScreenSize.GameTopScreenThreshold)
            {
                newPosition.y = ScreenSize.GameTopScreenThreshold;
            }

            transform.position = newPosition;
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            enabled = false;
        }
    }
}