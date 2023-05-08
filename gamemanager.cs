using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{  
    public GameObject pausePanel;

    bool gamehasended = false;

    public float restartdelay = 1f;

    public GameObject CompletelevelUI;

    public void Completelevel(){
        CompletelevelUI.SetActive(true);
        Debug.Log("LEVEL WON!!");
    }

    public void Endgame(){
        if (gamehasended == false){
            gamehasended = true;
            Debug.Log("GAME OVER!");
            Invoke("Restart", restartdelay);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }

    public void OnPause()
    {
        //pai=use panel.setActive(true)
        pausePanel.SetActive(true);
        Time.timeScale = 0;

    }
    public void Onplay(){
        Time.timeScale = 1;
        
        pausePanel.SetActive(false);
    }
}
