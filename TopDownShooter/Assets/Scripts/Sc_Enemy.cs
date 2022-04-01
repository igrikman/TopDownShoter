using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Enemy : MonoBehaviour
{
    [SerializeField] private Transform player;
    private new Rigidbody2D rigidbody;
    private Vector2 movement;
    [Header("Parametrs Enemy")]
    [SerializeField] private float health;
    [SerializeField] private float speed;
    
    private void Start()
    {
        rigidbody =GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("TakeDamage");
            TakeDamage();
        }
    }
    private void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rigidbody.rotation = angle;
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate()
    {
        MoveEnemy(movement);
    }
    private void MoveEnemy(Vector2 direction)
    {
        rigidbody.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }
    private void TakeDamage()
    {
        if (health > 5)
        {
            health -= 5;
        }
        else
        {
            Death();
        }
    }
    private void Death()
    {
        Destroy(gameObject);
    }
    
}
