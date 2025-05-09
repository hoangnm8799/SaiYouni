using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHp;
    public int currentHp;
    public float weight;
    public string enemyName;
    public float speed = 2.0f;

    private string[] enemyNames = { "Goblin", "Orc", "Troll", "Vampire", "Zombie" };

    public Enemy(int maxHp, int currentHp, float weight, string enemyName, float speed)
    {
        this.maxHp = maxHp;
        this.currentHp = currentHp;
        this.weight = weight;
        this.enemyName = enemyName;
        this.speed = speed;
    }

    public Enemy(int maxHp) { this.maxHp = maxHp; }

    public Enemy() { }

    void Awake()
    {
        SetRandomHp();
        SetRandomName();
        SetRandomWeight();
    }

    void Move()
    {
        Debug.Log(enemyName + " is moving with speed: " + speed);
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        Debug.Log(enemyName + " took " + damage + " damage. Remaining HP: " + currentHp);

        if (!IsAlive())
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log(enemyName + " has died.");
        Destroy(gameObject);
    }

    void SetRandomName()
    {
        this.enemyName = enemyNames[Random.Range(0, enemyNames.Length)];
        Debug.Log("New enemy named: " + this.enemyName);
    }

    void SetRandomWeight()
    {
        this.weight = Random.Range(40.0f, 100.0f);
        Debug.Log(this.enemyName + " has a weight of: " + this.weight + " kg.");
    }

    void SetRandomHp()
    {
        this.maxHp = Random.Range(1, 100);
        Debug.Log(this.maxHp + " has: " + this.maxHp);
    }

    bool IsAlive()
    {
        return currentHp > 0;
    }
}
