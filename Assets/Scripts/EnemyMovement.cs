using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    private GameObject player;
    private AI ai;
    private bool isMoving = false;  
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        ai = GetComponent<AI>();
    }

    // Update is called once per frame
    void Update()
    {
         if (!isMoving && Vector3.Distance(transform.position, player.transform.position) > 1)
        {
            StartCoroutine(MoveTowardsPlayer());
        }
    }
     IEnumerator MoveTowardsPlayer()
    {
        isMoving = true;
        ai.MoveTowardsPlayer(player.transform.position);
        // Move enemy towards player using AI logic
        yield return null;
        isMoving = false;
    }
}
