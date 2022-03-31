using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_PistolBullet : MonoBehaviour
{
    [SerializeField] private float speed;
    void Start()
    {
        Destroy(gameObject, 2f);
    }
    void Update()
    {
        transform.Translate(Vector2.right * speed* Time.deltaTime);

        
    }
}
