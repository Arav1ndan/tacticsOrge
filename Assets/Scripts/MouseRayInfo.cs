using UnityEngine;
using TMPro;
public class MouseRayInfo : MonoBehaviour
{
    public TMP_Text tileInfoText;
    public GameObject ObstaclePrefab;
    void Update()
    {
        RayInfo();
    }

    private void RayInfo()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log("hited : " + hit.collider.gameObject.name);
            Tile tile = hit.transform.GetComponent<Tile>();
            if (tile != null)
            {
                //Debug.Log("Tile script is attached");
                tileInfoText.text = $"Tile position: ({tile.i},{tile.j})";
                // if (Input.GetMouseButtonDown(0))
                // {
                //     Vector3 spawnPosition = new Vector3(tile.i, 0.5f, tile.j);
                //     Instantiate(ObstaclePrefab, spawnPosition, Quaternion.identity);
                // }

            }

        }
    }

}
