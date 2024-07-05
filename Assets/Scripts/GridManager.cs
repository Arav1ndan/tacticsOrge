using UnityEngine;

public class GridManager : MonoBehaviour
{
   //Tile Prefab.
    public GameObject TilePrefab;
   //TileSize.
   public int GridSize  = 10;
    //
   void Start()
   {
        for(int i =0; i< GridSize;i++)
        {
            for(int j =0; j < GridSize; j++ )
            {
                Vector3 position = new Vector3(i, 0, j);
                GameObject Tile = Instantiate(TilePrefab,position, Quaternion.identity);

                Tile.transform.parent = gameObject.transform;
            }
        }
   }
}
