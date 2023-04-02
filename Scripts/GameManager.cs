using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool wetBall = false; 
    bool endGame = false; 
    public float restartDelay = 1f;
    public GameObject completeLevelUI; //variable to reference the level complete text
    public GameObject noSwimmingUI; // reference to no swimming text
    public GameObject titleUI;
    public GameObject instructionUI;
    public GameObject exitUI;
    public GameObject congratsUI;
    public GameObject findButtonUI;
    public GameObject pauseUI;

    bool paused = false;

    void Start() 
    {
        if (SceneManager.GetActiveScene().name == "TitleScreen")
        {
            titleUI.SetActive(true);
            instructionUI.SetActive(true);
            exitUI.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().name =="Final")
        {
            exitUI.SetActive(true);
            congratsUI.SetActive(true);
        }
        else
        {
            findButtonUI.SetActive(true);
            Invoke("bTextOff", 3f);
        }
    }
    void Update() 
    {
        if (Input.GetKeyDown("escape")) // to exit to title
        {
            EndGame();
        }

        if (Input.GetKeyDown("return") && SceneManager.GetActiveScene().name == "TitleScreen") // to jump to next scene
        {
            NextScene();
            FindObjectOfType<AudioManager>().Stop("Theme");
        }

        if (Input.GetKeyDown("space")) // space bar for pause button
        {
            if (paused)
            {
                ResumeGame();
                paused = false;
                pauseUI.SetActive(false);
            }
            else
            {
                PauseGame();
                paused = true;
                pauseUI.SetActive(true);
            }
        }
    }

    public void CompleteLevel()
     {
         completeLevelUI.SetActive(true); // turn on level complete text

     }

    public void EndGame()
   {
        if (endGame == false) // so we only run it once
        {
            endGame = true;
            //Debug.Log("See you next time");
            Application.Quit();
            Invoke("GoTitle", restartDelay);
        }
   }

   void Restart()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void HitWater()
   {
    if (wetBall == false) // so we only run it once
    {
        wetBall = true;
        noSwimmingUI.SetActive(true);
        Invoke("Restart", restartDelay);
        FindObjectOfType<AudioManager>().Play("PlayerDeath");
    }
   }

   void GoTitle()
   {
        SceneManager.LoadScene("TitleScreen");
   }

   void NextScene()
   {
    if (SceneManager.GetActiveScene().name != "Final") // if its not the final scene
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1); // go to the next scene
    }
   }

   void bTextOff() 
   {
        findButtonUI.SetActive(false);
   }

   void PauseGame()
   {
    Time.timeScale = 0;
   }
   void ResumeGame()
   {
    Time.timeScale = 1;
   }
}
