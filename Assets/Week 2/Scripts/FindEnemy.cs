using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class FindEnemy : MonoBehaviour
{
    public List<Enemy> enemyList;

    public void Start()
    {
        Debug.Log("Start() called from: " + gameObject.name + " | ID: " + GetInstanceID());
        Debug.Log("Enemy count: " + (enemyList != null ? enemyList.Count.ToString() : "NULL"));
        Debug.Log("FIND MIN MAX ENEMIE");
        FindEnemyWithSmallestHealth(enemyList);
        FindEnemyWithLargestHealth(enemyList);
    }
    //----------------------Edit below here --------------------
    public Enemy FindEnemyWithSmallestHealth(List<Enemy> enemies)
    {
        Enemy smallestEnemy = null;
        int smallestHp = int.MaxValue;
        foreach (Enemy enemy in enemies)
        {
            if (enemy.maxHp < smallestHp)
            {
                smallestEnemy = enemy;
                smallestHp = enemy.maxHp;
            }
        }
        Debug.Log("A smallest enemy is: " + smallestEnemy.enemyName + " (" + smallestHp + " HP)");
        return smallestEnemy;
    }

    public Enemy FindEnemyWithLargestHealth(List<Enemy> enemies)
    {
        Enemy largestEnemy = null;
        int largestHp = 0;
        foreach (Enemy enemy in enemies)
        {
            if (enemy.maxHp > largestHp)
            {
                largestEnemy = enemy;
                largestHp = enemy.maxHp;
            }
        }
        Debug.Log("A largest enemy is: " + largestEnemy.enemyName + " (" + largestHp + " HP)");
        return largestEnemy;
    }

    //----------------------Edit above here --------------------
}
