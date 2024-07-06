using UnityEngine;

public class GridManager : MonoBehaviour
{
   //Tile Prefab.
    public GameObject TilePrefab;

     public GameObject ObstaclePrefab;
     public ObstacleData obstacleData;
   //TileSize.
   public int GridSize  = 10;
    //
   void Start()
   {
        SpawnTiles();
        //SpawnObstacles();
   }
    void SpawnTiles()
    {
        for(int i = 0; i < GridSize;i++)
        {
            for(int j =0; j < GridSize; j++ )
            {
                Vector3 position = new Vector3(i, 0, j);
                GameObject Tile = Instantiate(TilePrefab,position, Quaternion.identity);
                Tile.name = $"Tile_{i}_{j}";
                Tile.AddComponent<Tile>().SetPosistion(i,j);
                Tile.transform.parent = gameObject.transform;
            }
        }
    }
    // void SpawnObstacles()
    // {
    //     if (obstacleData == null)
    //     {
    //         Debug.LogWarning("Obstacle Data is not assigned.");
    //         return;
    //     }

    //     int rowCount = obstacleData.obstacles.GetLength(0);
    //     int colCount = obstacleData.obstacles.GetLength(1);

    //     for (int i = 0; i < rowCount; i++)
    //     {
    //         for (int j = 0; j < colCount; j++)
    //         {
    //             if (obstacleData.obstacles[i, j])
    //             {
    //                 Vector3 obstaclePosition = new Vector3(i, 0.5f, j); // Adjust height as needed
    //                 Instantiate(ObstaclePrefab, obstaclePosition, Quaternion.identity, transform);
    //             }
    //         }
    //     }
    // }
}
