using UnityEngine;
public class Target : MonoBehaviour
{
    public GameManager gameManager;
    public int score;
    public int maxHealth = 3;
    private int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void Hit()
    {
        currentHealth--;
        Debug.Log("Health remaining: " + currentHealth);
        if (currentHealth <= 0)
        {
            GameManager.Instance.AddScore(1); ;
            Debug.Log("Target destroyed! Score: " + gameManager.score);
            Destroy(gameObject);
        }
    }
}