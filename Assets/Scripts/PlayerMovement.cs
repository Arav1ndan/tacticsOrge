using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;

    public bool isMoving = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isMoving)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Tile tileInfo = hit.transform.GetComponent<Tile>();
                if (tileInfo != null)
                {
                    StartCoroutine(MoveToPosition(new Vector3(tileInfo.i, 0, tileInfo.j)));
                }
            }
        }
    }
    IEnumerator MoveToPosition(Vector3 target)
    {
        isMoving = true;
        while (transform.position != target)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            yield return null;
        }
        isMoving = false;
    }
}
