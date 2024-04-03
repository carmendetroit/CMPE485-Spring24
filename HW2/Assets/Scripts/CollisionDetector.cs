using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
            //
    
        if((collision.gameObject.CompareTag("Guard") && gameObject.CompareTag("Player"))||collision.gameObject.CompareTag("Player") && gameObject.CompareTag("Guard")){
            Debug.Log("Guard Player Collided");
            FailGame();
        }
        
        if((collision.gameObject.CompareTag("Box")&& gameObject.CompareTag("EndGate"))||(collision.gameObject.CompareTag("EndGate")&& gameObject.CompareTag("Box"))){
            Debug.Log("Box EndGate Collided");
            CompleteGame();
        }
    
    }

    private void FailGame()
    {
        SceneManager.LoadScene("EndGameFail");
        // Note: This will only work in standalone builds; in the Unity editor or web builds, use a different game over logic
    }
    private void CompleteGame()
    {
        SceneManager.LoadScene("EndGameSuccess");

        // Note: This will only work in standalone builds; in the Unity editor or web builds, use a different game over logic
    }
}
