using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Player : MonoBehaviour
{
    [Header("Parametrs")]
    [SerializeField] private float speed;
    private Vector2 direction;
    private Rigidbody2D rigidBody;

    private void Start()
    {
       rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); 
    }
    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + direction * speed * Time.deltaTime);
    }
}
