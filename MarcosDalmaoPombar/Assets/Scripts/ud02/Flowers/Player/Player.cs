using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Variables
    private float _speed = 2.0f;
            float _turnSpeed = 150.0f;

    private float _horizontal;
            float _vertical;
    private Animator _anim;
    private Rigidbody _rb;

    private Ray _ray;
    private RaycastHit _hit;
    private bool _isGrounded;
    private bool _canPlayerJump;

    public LayerMask GroudnMask;
    public float RayLength;
    public float JumpForce;

 private void Awake()
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        InputPlayer();
        Move();
        Turn();
        Animating();
        CanJump();

    
        

    

    }

    private void FixedUpdate() 
    {

        LaunchRaycast();
        if(_canPlayerJump)
        {

            _canPlayerJump = false;
            Jump();

        }

   
    }

    private void LaunchRaycast()
    {

        _ray.origin = transform.position;
        _ray.direction = -transform.up;

        if(Physics.Raycast(_ray, out _hit, RayLength))
        {

            _isGrounded = true;
        

        }
        else
        {

            _isGrounded = false;
        

        }



    }
    private void InputPlayer()
    {

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");


    }

    private void Move()
    {

        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);


    }


    private void Turn()
    {

        transform.Rotate(Vector3.up * _turnSpeed * _horizontal * Time.deltaTime);


    }

    private void Animating()
    {

        if(_vertical !=0)
        {

            _anim.SetBool("IsMoving", true);

        }
        else
        {

            _anim.SetBool("IsMoving", false);

        }

       if (Input.GetMouseButtonDown(0))
        {

           _anim.SetTrigger("Attack");

        }

    
       if (Input.GetKeyDown(KeyCode.Space))
       {

            _anim.SetTrigger("Jump");

       }


    }

    private void CanJump()
    {

        if(Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {

            _canPlayerJump = true;

        }

    }

    private void Jump()
    {

        _rb.AddForce(Vector3.up * JumpForce);

    }


}