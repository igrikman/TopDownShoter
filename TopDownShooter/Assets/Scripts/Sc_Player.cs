using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Player : MonoBehaviour
{
    [Header("Parametrs")]
    [SerializeField] private float speed;
    [SerializeField] private float health;
    [Header("Guns")]
    [SerializeField] private Transform shotDirection;
    [SerializeField] private GameObject pistolBullet;
    private float timeShot;
    [SerializeField] private float statrTime;

    private Vector2 direction;
    private Rigidbody2D rigidBody;

    private void Start()
    {
       rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); 

        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition)- transform.position;
        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0,0, angle);
        if(timeShot <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(pistolBullet, shotDirection.position, transform.rotation);
                timeShot = statrTime;
            }  
        }
        else
        {
            timeShot -= Time.deltaTime;
        }
        Death();
    }
    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + direction * speed * Time.deltaTime);
    }
   
    private void Death()
    {
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
