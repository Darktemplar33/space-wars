using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    int maxHealth;
    int currentHealth;

    public healthBar healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = GetComponent<unitsCreator>().health;
        currentHealth = maxHealth;
        healthSlider.setMaxHealth(maxHealth);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(5);
        }
    }
    void takeDamage(int amount)
    {
        currentHealth -= amount;
        healthSlider.setHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
