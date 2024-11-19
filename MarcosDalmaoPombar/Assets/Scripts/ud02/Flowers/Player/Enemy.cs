using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Update()
    {



    }

    private Animator _anim;
    private Rigidbody _rb;

     void OnCollisionEnter(Collision infoCollision)
    {

        if (infoCollision.gameObject.CompareTag("Flor"))
        {
            Destroy(gameObject);
        }
    }



    
}