using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed = 10;
    private bool topHareketi = false;
    
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if(collision2D.gameObject.name == "PlayerLeft")
        {
           float y = vurusYerı(transform.position,collision2D.transform.position,collision2D.collider.bounds.size.x);

           Vector2 yon = new Vector2(1,y).normalized;

           GetComponent<Rigidbody2D>().velocity = yon * speed;
        }

        if(collision2D.gameObject.name == "PlayerRight")
        {
           float y = vurusYerı(transform.position,collision2D.transform.position,collision2D.collider.bounds.size.x);

           Vector2 yon = new Vector2(-1,y).normalized;

           GetComponent<Rigidbody2D>().velocity = yon * speed;
        }

        float vurusYerı(Vector2 topPozisyonu, Vector2 vurduguYer, float colliderBoyutu)
        {
            return(topPozisyonu.y - vurduguYer.y) / colliderBoyutu;
        }
    }

    void Update()
    {
        if(GameManager.EvAnahtarı.oyunbasladimi == true && topHareketi == false)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
            topHareketi = true;
        }
    }
}
