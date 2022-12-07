using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    // Movement Speed
    public float speed = 100.0f;

    void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // This function is called whenever the ball
        // collides with something
        //1 - 0.5  0  0.5   1 < -x value depending on where it was hit
        //===================  <- this is the racket

        // Hit the Racket?
        if (col.gameObject.name == "racket")
        {
            FindObjectOfType<SoundControl>().RacketSound();
            // Calculate hit Factor
            float x = hitFactor(transform.position,
                              col.transform.position,
                              col.collider.bounds.size.x);

            // Calculate direction, set length to 1
            Vector2 dir = new Vector2(x, 1).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if(col.gameObject.tag == "wall")
        {
            FindObjectOfType<SoundControl>().WallSound();
        }
        if (col.gameObject.name == "border_bottom")
        {
            transform.gameObject.SetActive(false);
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                float racketWidth)
    {
        // ascii art:
        //
        // 1  -0.5  0  0.5   1  <- x value
        // ===================  <- racket
        //
        return (ballPos.x - racketPos.x) / racketWidth;
    }
}
