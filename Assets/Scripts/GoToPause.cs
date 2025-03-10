using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPause : MonoBehaviour
{
  
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
        SceneManager.LoadScene("PauseScreen");
        }
        
    }
}
