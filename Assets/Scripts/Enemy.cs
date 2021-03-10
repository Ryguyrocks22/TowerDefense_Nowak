using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;
    public float health = 100;
    public int worth = 50;
    [HideInInspector]
    public float speed;


    void Start()
    {
        speed = startSpeed;
        
    }

    public void TakeDamage (float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            Die();
        }
    }

    public void Slow(float pct)
    {
        speed = startSpeed * (1f - pct);
    }

    void Die()
    {
        PlayerStats.Money += worth;
        Destroy(gameObject);
    }

    
}
