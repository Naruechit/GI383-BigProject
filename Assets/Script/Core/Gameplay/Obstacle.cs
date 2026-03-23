using Unity.VisualScripting;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Health health;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Hit");
           health.TakeDamage(10);
        }
    }
}
