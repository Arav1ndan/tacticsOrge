using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
public class GridEditorWindow : EditorWindow
{
   private bool[,] toggles = new bool[10, 10];
    private ObstacleData obstacleData;

    [MenuItem("Tools/Grid Editor")]
    public static void ShowWindow()
    {
        GetWindow<GridEditorWindow>("Grid Editor");
    }

    void OnGUI()
    {
        obstacleData = (ObstacleData)EditorGUILayout.ObjectField("Obstacle Data", obstacleData, typeof(ObstacleData), false);

        if (obstacleData == null) return;

        if (GUILayout.Button("Load"))
        {
            LoadData();
        }

        for (int i = 0; i < 10; i++)
        {
            GUILayout.BeginHorizontal();
            for (int j = 0; j < 10; j++)
            {
                toggles[i, j] = GUILayout.Toggle(toggles[i, j], $"{i},{j}");
            }
            GUILayout.EndHorizontal();
        }

        if (GUILayout.Button("Save"))
        {
            SaveData();
        }
    }

    void LoadData()
    {
        if (obstacleData == null) return;

        if (obstacleData.obstacles == null || obstacleData.obstacles.Count != 10)
        {
            obstacleData.Initialize(10, 10);
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                toggles[i, j] = obstacleData.obstacles[i].row[j];
            }
        }
    }

    void SaveData()
    {
        if (obstacleData == null)
        {
            Debug.LogWarning("Obstacle Data is not assigned. Cannot save.");
            return;
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                obstacleData.obstacles[i].row[j] = toggles[i, j];
            }
        }

        EditorUtility.SetDirty(obstacleData);
        AssetDatabase.SaveAssets();
        Debug.Log("Obstacle data saved successfully.");
    }
}
