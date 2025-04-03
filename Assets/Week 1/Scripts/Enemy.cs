using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHp = 100;
    public int currentHp;
    public float weight;
    public string name;
    public float speed = 2.0f;

    private string[] enemyNames = { "Goblin", "Orc", "Troll", "Vampire", "Zombie" };

    void Awake()
    {
        SetRandomName();
        SetRandomWeight();
    }

    void Move()
    {
        Debug.Log(name + " is moving with speed: " + speed);
    }

    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        Debug.Log(name + " took " + damage + " damage. Remaining HP: " + currentHp);

        if (!IsAlive())
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log(name + " has died.");
        Destroy(gameObject);
    }

    void SetRandomName()
    {
        name = enemyNames[Random.Range(0, enemyNames.Length)];
        Debug.Log("New enemy named: " + name);
    }

    void SetRandomWeight()
    {
        weight = Random.Range(40.0f, 100.0f);
        Debug.Log(name + " has a weight of: " + weight + " kg.");
    }

    bool IsAlive()
    {
        return currentHp > 0;
    }
}
