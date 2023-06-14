using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DikeyHareket : MonoBehaviour
{
    public float speed = 15;
    public string axis = "Vertical";
    
    void Update()
    {
        if(GameManager.EvAnahtarı.oyunbasladimi == true)
        {
            float vertical = Input.GetAxisRaw(axis);

            GetComponent<Rigidbody2D>().velocity = new Vector2(0 , vertical * speed);
        }
    }
}