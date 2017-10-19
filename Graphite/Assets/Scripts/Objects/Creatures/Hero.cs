using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Creature
{
    public override void Update()
    {
        base.Update();
        move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //if (Input.GetMouseButtonDown(0))
        //{
        //    attack();
        //}
        faceMouse();
        
    }

    public void faceMouse()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 objectPos = Camera.main.WorldToScreenPoint(rb.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;
        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

    protected override Inventory die()
    {
        return null;
    }
}
