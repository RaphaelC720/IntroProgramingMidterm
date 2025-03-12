using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public float countdown;
    public float TimeToSpawn;
    public GameObject coin;
    public UnityEngine.Vector2 Range;

    void Start()
    {
        
    }

    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            UnityEngine.Vector3 where = transform.position + new UnityEngine.Vector3(UnityEngine.Random.Range(-Range.x,Range.x), UnityEngine.Random.Range(-Range.y, Range.y), 0);
            Instantiate(coin, where, UnityEngine.Quaternion.identity);
            countdown = TimeToSpawn;
        }
    }
}
