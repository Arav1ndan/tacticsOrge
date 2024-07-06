using UnityEngine;


public interface AI
{
    void MoveTowardsPlayer(Vector3 playerPosition);
}
public class EnemyAI : MonoBehaviour
{
    public float Speed = 2f;

    public void MoveTowardsPlayer(Vector3 playerPosition)
    {
     
    }
}
