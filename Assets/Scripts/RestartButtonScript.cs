using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtons : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Whack a mole game"); //Loads the main game scene when the restart button is clicked
    }
}