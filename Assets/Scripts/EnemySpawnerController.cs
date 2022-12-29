using UnityEngine;

namespace SpriteChaser
{
    public class EnemySpawnerController : MonoBehaviour
    {
        public GameObject Enemy;

        private const float minimumDistanceBetweenEnemyAndPlayer = 1.5f;

        public void Start()
        {
            for (int i = 0; i < 1000; i++)
            {
                Instantiate(Enemy, transform.position + RandomizeEnemyStartingPosition(), Quaternion.identity);
            }
        }

        private Vector3 RandomizeEnemyStartingPosition()
        {
            float xCoordinate = Random.Range(minimumDistanceBetweenEnemyAndPlayer, ScreenSize.GameRightScreenThreshold);
            float yCoordinate = Random.Range(minimumDistanceBetweenEnemyAndPlayer, ScreenSize.GameTopScreenThreshold);

            int signRandomizer = Random.Range(0, 4);

            switch (signRandomizer)
            {
                case 0:
                    return new Vector3(xCoordinate, yCoordinate);

                case 1:
                    return new Vector3(-xCoordinate, yCoordinate);

                case 2:
                    return new Vector3(xCoordinate, -yCoordinate);

                case 3:
                    return new Vector3(-xCoordinate, -yCoordinate);

                default:
                    throw new System.ArgumentOutOfRangeException($"Value out of range has been encountered: {signRandomizer}.");
            }
        }
    }
}