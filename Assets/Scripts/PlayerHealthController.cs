using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;
    // awake function is another default function built into unity
    // awake happens when an object becomes activated for the first time.
    private void Awake()
    {
        instance = this;
    }

    // Declare current physical health and full health
    public float currentHealth;
    public float maxHealth = 100f;

    public Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        // At first, the health is full 
        currentHealth = maxHealth;

        // health slider
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
    }



    // Update is called once per frame
    void Update()
    {
        /* check for damage to a player
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10f);
        }*/
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

        healthSlider.value = currentHealth; 

        Debug.Log("Current Healt" + currentHealth);
    }
}
