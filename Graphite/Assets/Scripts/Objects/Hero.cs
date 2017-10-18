using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{

    private Vector2 position;
    protected Rigidbody2D rb;

    [SerializeField]
    [Range(0.01f, 0.5f)]
    private float maxSpeed = 0.2f;

    protected void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public Hero()
    {
        position = new Vector2();
    }

    private void move(float xAxis, float yAxis)
    {
        Vector2 movement = new Vector2(xAxis, yAxis);
        position += Vector2.ClampMagnitude(movement, maxSpeed);
        rb.position = position;
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

    }
}
