﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Animator m_Animator;
    Vector3 m_Movement;
    public float turnSpeed = 20f;

    Quaternion m_Rotation = Quaternion.identity;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");

        //m_Movement.Set(horizontal, 0f, vertical);
        //m_Movement.Normalize();

        //bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        //bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
        //bool isWalking = hasHorizontalInput || hasVerticalInput;
        ////m_Animator.SetBool("IsWalking", isWalking);

        //Vector3 desiredForward = Vector3.RotateTowards(transform.forward, m_Movement, turnSpeed * Time.deltaTime, 0f);
        //m_Rotation = Quaternion.LookRotation(desiredForward);


        //if(Input.anyKey)
        //{
        //    m_Rigidbody.MovePosition(m_Rigidbody.position + m_Movement * Time.deltaTime);//m_Animator.deltaPosition.magnitude);
        //    m_Rigidbody.MoveRotation(m_Rotation);
        //}
        Debug.Log(transform.forward);
    }


}
