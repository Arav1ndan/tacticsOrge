using UnityEngine;
using System.Collections.Generic;
using System;


[Serializable]
public class BoolRow
{
   public List<bool> row = new List<bool>();
}
[CreateAssetMenu(fileName = "NewObstacleData", menuName = "ScriptableObjects/ObstacleData", order = 1)]
public class ObstacleData : ScriptableObject
{
   public List<BoolRow> obstacles = new List<BoolRow>();

   public void Initialize(int rows, int columns)
   {
      obstacles.Clear();
      for (int i = 0; i < rows; i++)
      {
         BoolRow newRow = new BoolRow();
         for (int j = 0; j < columns; j++)
         {
            newRow.row.Add(false);
         }
         obstacles.Add(newRow);
      }
   }
}
