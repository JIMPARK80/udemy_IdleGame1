using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public Rigidbody2D theRB;
    public float moveSpeed;
    private Transform target;

    public float damage;

    // Continuous damage implementation
    public float hitWaitTime = 1f;
    private float hitCounter;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame

    void Update()
    {
        theRB.velocity = (target.position - transform.position).normalized * moveSpeed;
    
        if(hitCounter > 0f)
        {
            hitCounter -= Time.deltaTime;
        }
    }



    // use singleton, which is a way of having one version of a script that any other script can access

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // when enemy meet the player and the hit count is zero, take damage
        if (collision.gameObject.tag == "Player" && hitCounter <= 0f)
        {
            PlayerHealthController.instance.TakeDamage(damage);
            Debug.Log("damage: " + damage);

            // same number of hits and same amount of time to wait
            hitCounter = hitWaitTime;
        }
    }
}
