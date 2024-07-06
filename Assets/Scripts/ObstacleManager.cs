using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
 public ObstacleData obstacleData;
    public GameObject obstaclePrefab;

    void Start()
    {
        if (obstacleData == null)
        {
            Debug.LogError("Obstacle Data is not assigned to ObstacleManager.");
            return;
        }
        GenerateObstacles();
    }

    void GenerateObstacles()
    {
        if (obstacleData.obstacles == null || obstacleData.obstacles.Count == 0)
        {
            Debug.LogWarning("Obstacle data is empty or not initialized.");
            return;
        }

        int rowCount = obstacleData.obstacles.Count;
        int colCount = obstacleData.obstacles[0].row.Count;

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                if (obstacleData.obstacles[i].row[j])
                {
                    Vector3 spawnPosition = new Vector3(i, 0.5f, j);
                    Debug.Log($"Spawning obstacle at position: {spawnPosition}");
                    Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
                }
            }
        }
    }
}


//  void OnDrawGizmos()
//     {
//         if (obstacleData == null || obstacleData.obstacles == null)
//             return;

//         Gizmos.color = Color.red;

//         int rowCount = obstacleData.obstacles.Count;
//         int colCount = obstacleData.obstacles[0].row.Count;

//         for (int i = 0; i < rowCount; i++)
//         {
//             for (int j = 0; j < colCount; j++)
//             {
//                 if (obstacleData.obstacles[i].row[j])
//                 {
//                     Vector3 position = new Vector3(i, 0.5f, j);
//                     Gizmos.DrawCube(position, Vector3.one);
//                 }
//             }
//         }
//     }