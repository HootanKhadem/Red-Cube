using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameEnded;
    public float restartDelay = 3f;
    public GameObject completeLevelUi;
    
    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Invoke("RestartGame", restartDelay);
        }
    }
    
    public void CompleteLevel()
    {
        completeLevelUi.SetActive(true);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
