using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    
    public void OnStartClick() //function, when button is clicked
    {
        SceneManager.LoadScene(1); //loading the whack a mole scene
    }
    
}
