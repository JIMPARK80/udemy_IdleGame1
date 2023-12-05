using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    // Declare current physical health and full health
    public float currentHealth;
    public float maxHealth = 100f;


    // Start is called before the first frame update
    void Start()
    {
        // At first, the health is full 
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        // check for damage to a player
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10f);
        }
    }

    // to set up a damaging setting for the player
    public void TakeDamage(float damageToTake)
    {
        currentHealth -= damageToTake;
        
        // if current health is less than or equal to zero,
        // then take the game object is to deactivate
        if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
