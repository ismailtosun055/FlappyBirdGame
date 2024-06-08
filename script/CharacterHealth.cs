using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    public bool enemyattack;
    public float enemytimer;
    void Start()
    {
        currentHealth = maxHealth;
        enemytimer = 1.5f;
        
    }

    void  EnemyAttackSpacing()
    {
        if(enemyattack == false)
        {
            enemytimer -= Time.deltaTime;
        }
        if(enemytimer < 0)
        {
            enemytimer = 0f;
        }
        if(enemytimer == 0)
        {
            enemyattack = true;
            enemytimer = 1.5f;
        }

    }

    public void TakeDamage(int damage)
    {
        if(enemyattack)
        {
            currentHealth -= 20;
            enemyattack = false;
        }

        healthBar.SetHealth(currentHealth);
    }






    void Update()
    {
        EnemyAttackSpacing();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
        
    }
}
