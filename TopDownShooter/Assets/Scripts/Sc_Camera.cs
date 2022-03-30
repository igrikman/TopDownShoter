using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Camera : MonoBehaviour
{
    [Header("Parametrs")]
    [SerializeField] private float Speed;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Camera;

    void FixedUpdate()
    {
        Vector3 target = new Vector3()
        {
            x = Player.transform.position.x,
            y = Player.transform.position.y,
            z = Player.transform.position.z - 10,
        };
        Vector3 pos = Vector3.Lerp(Camera.transform.position, target, Speed * Time.fixedDeltaTime);

        Camera.transform.position = pos;
    }

    

}

