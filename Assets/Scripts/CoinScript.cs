using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float TimeToDespawn = 5f;

    //The player calls this function on the coin whenever they bump into it
    //You can change its contents if you want something different to happen on collection
    //For example, what if the coin teleported to a new location instead of being destroyed?
    public void GetBumped()
    {
        //This destroys the coin
        Destroy(gameObject);
    }

    void Update()
    {
        TimeToDespawn -= Time.deltaTime;

        if(TimeToDespawn <= 0)
        {
            Destroy(gameObject);
        }   
    }
}
