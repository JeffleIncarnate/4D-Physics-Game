// Modules
using UnityEngine;
using UnityEngine.SceneManagement;

// Unity Class
public class HahaDead : MonoBehaviour
{
    // Variables
    public bool dead = false;
    public GameObject deadMenuUI;
    public GameObject PlayerDead;

    // On Collion Enter Method
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // If Statement
        if (collision.gameObject.tag == "Ded")
        {
            // Calling Dead Method
            Dead();
            Debug.Log("Haha bad lol trash");
        }
    }
    
    // Dead Method
    public void Dead() 
    {
        deadMenuUI.SetActive(true);
        Time.timeScale = 0f;
        dead = true;

        // Particals
        Instantiate(PlayerDead, transform.position, Quaternion.identity);
    }

    // Play Again Method
    public void PlayAgain()
    {
        // get the current scene name 
        string sceneName = SceneManager.GetActiveScene().name;

        // load the same scene
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        Time.timeScale = 1f;
    }
}
