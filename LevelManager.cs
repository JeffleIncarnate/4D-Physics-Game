// Modules
using UnityEngine;
using UnityEngine.SceneManagement;

// Unity Class
public class LevelManager : MonoBehaviour
{
    // Variables
    public bool levelNext = false;
    public GameObject nextLevelUI;

    // On Collision Enter Method
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "End")
        {
            // Calling Level Method
            Level();
        }
    }

    // Next Level UI active
    public void Level()
    {
        nextLevelUI.SetActive(true);
        Time.timeScale = 1f;
        levelNext = true;
    }

    // Quit Method
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting Game...");
    }

    // Menu Method
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    // Next Level Method
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
