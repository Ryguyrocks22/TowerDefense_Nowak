using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public int value = 50;
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        target = Waypoints.points[0];
    }

    public void TakeDamage (int amount)
    {
        health -= amount;

        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        PlayerStats.Money += value;
        Destroy(gameObject);
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.3f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }

    void EndPath ()
    {
        PlayerStats.Lives--;
        Destroy(gameObject);
    }
}
