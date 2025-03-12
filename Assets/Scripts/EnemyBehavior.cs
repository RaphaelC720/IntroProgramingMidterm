using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject Hazard;
    
    void Start()
    {
        
    }

   
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            Destroy(Hazard);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Debug.Log("Destroyed");
            Destroy(Hazard);
        }
    }
}
