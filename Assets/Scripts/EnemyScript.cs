using System;
using System.Numerics;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody2D RB2;
    public GameObject ObjectSpawned;
    public UnityEngine.Vector2 Range;
    public float speed;
    public float TimeToSpawn;
    public float NextSpawn;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeToSpawn -= Time.deltaTime;

        //spawn enemy after 5 seconds
        if (TimeToSpawn <= 0)
        {
                UnityEngine.Vector3 where = transform.position + new UnityEngine.Vector3(UnityEngine.Random.Range(-Range.x, Range.x), 
                UnityEngine.Random.Range(-Range.y, Range.y), 0);            
                Instantiate(ObjectSpawned, where, UnityEngine.Quaternion.identity);
            TimeToSpawn = NextSpawn;
        }
        //kill enemy if shot
        
        
        //enemy movement
        UnityEngine.Vector2 vel = new UnityEngine.Vector2(0,0);

        //if(transform.position.x <= player.transform.position.x)
        {
            vel.x = speed;
        }
        //if(transform.position.x <= player.transform.position.x)
        {
            vel.x = -speed;
        }
        //if(transform.position.x <= player.transform.position.x)
        {
            vel.y = speed;
        }
        //if(transform.position.x <= player.transform.position.x)
        {
            vel.y = -speed;
        }

        RB2.linearVelocity = vel;
    }

}

