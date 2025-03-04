using UnityEditor.Overlays;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        Debug.Log("Start Game");

        // Load the game scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("main");
        // Load the high score
        DataStore.Instance.LoadHighScore();

    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        DataStore.Instance.SaveHighScore();
        // Quit the game
        //if in the Editor, quit play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            //if in a build, quit the application                   
            Application.Quit();
#endif
    }



}
