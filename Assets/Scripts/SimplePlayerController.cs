using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    //These are the player's Variables, the raw info that defines them
    
    //The Rigidbody2D is a component that gives the player physics, and is what we use to move
    public Rigidbody2D RB;
    
    //This will control how fast the player moves
    public float Speed = 5;

    public SpriteRenderer Sr;

    public Color ChangedColor = Color.blue;

    //Start automatically gets triggered once when the objects turns on/the game starts
    void Start()
    {
        //This is empty for now.
    }

    //Update is a lot like Start, but it automatically gets triggered once per frame
    //Most of an object's code will be called from Update--it controls things that happen in real time
    void Update()
    {
        //The code below controls the character's movement
        //First we make a variable that we'll use to record how we want to move
        Vector2 vel = new Vector2(0,0);
        
        //Then we use if statement to figure out what that variable should look like
        
        //If I hold the right arrow key, the player should move right. . .
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = Speed;
        }
        //If I hold the left arrow, the player should move left. . .
        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -Speed;
        }
        //If I hold the up arrow, the player should move up. . .
        if (Input.GetKey(KeyCode.W))
        {
            vel.y = Speed;
        }
        //If I hold the down arrow, the player should move down. . .
        if (Input.GetKey(KeyCode.S))
        {
            vel.y = -Speed;
        }
        
        //Finally, I take that variable and I feed it to the component in charge of movement
        RB.linearVelocity = vel;

        if (transform.position.x > 12.22f)
        {
            transform.position = new UnityEngine.Vector2(-12.22f, transform.position.y);
            Sr.color = Color.blue;
        }

        if (transform.position.x < -12.22f)
        {
            transform.position = new UnityEngine.Vector2(12.22f, transform.position.y);
        }

        if (transform.position.y > 5.51f)
        {
            transform.position = new UnityEngine.Vector2(transform.position.x, -5.51f);
        }

        if (transform.position.y < -5.51f)
        {
            transform.position = new UnityEngine.Vector2(transform.position.x, 5.51f);
        }
    }
}
