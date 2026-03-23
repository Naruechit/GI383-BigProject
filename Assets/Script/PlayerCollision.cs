using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject victoryUI;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            GameOver();
        }
        
        if (collision.CompareTag("Finish"))
        {
            Victory();
        }
    }

    void GameOver()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f; // ��ش��
    }

    void Victory()
    {
        victoryUI.SetActive(true);
        Time.timeScale = 0f;
    }
}