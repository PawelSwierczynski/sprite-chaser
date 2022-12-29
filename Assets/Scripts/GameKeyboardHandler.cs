using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpriteChaser
{
    public class GameKeyboardHandler : MonoBehaviour
    {
        private const float playerSpeed = 5;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene((int)SceneIndex.MainMenu);
            }

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (transform.position.x >= ScreenSize.GameLeftScreenThreshold)
                {
                    transform.position += new Vector3(-playerSpeed, 0) * Time.deltaTime;
                }
            }
            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (transform.position.x <= ScreenSize.GameRightScreenThreshold)
                {
                    transform.position += new Vector3(playerSpeed, 0) * Time.deltaTime;
                }
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                if (transform.position.y <= ScreenSize.GameTopScreenThreshold)
                {
                    transform.position += new Vector3(0, playerSpeed) * Time.deltaTime;
                }
            }
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                if (transform.position.y >= ScreenSize.GameBottomScreenThreshold)
                {
                    transform.position += new Vector3(0, -playerSpeed) * Time.deltaTime;
                }
            }
        }
    }
}