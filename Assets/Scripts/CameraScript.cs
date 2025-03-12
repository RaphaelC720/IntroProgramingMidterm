using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public Transform player;  // Drag the player here in the Inspector
    public float offsetY = 2f; // Adjust how high the camera is above the player
    public float fixedX;       // Fixed X position

    void Start()
    {
        fixedX = transform.position.x; // Store the initial X position
    }

    void LateUpdate()
    {
        if (player != null)
        {
            transform.position = new Vector3(fixedX, player.position.y + offsetY, transform.position.z);
        }
    }
}
