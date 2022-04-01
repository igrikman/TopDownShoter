using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_PistolBullet : MonoBehaviour
{
    [SerializeField] private float speed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("DestroyOnTrigger");
            Destroy(gameObject);
        }
    }
    void Start()
    {
        Invoke("BulletDestroy", 3f);
    }
    void Update()
    {
        transform.Translate(Vector2.right * speed* Time.deltaTime);
    }
    private void BulletDestroy()
    {
        Debug.Log("BulletDestroy");
        Destroy(gameObject);
    }
}
