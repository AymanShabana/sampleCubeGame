using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float restartDelay = 3f;
    public GameObject completeLevelUI;
    public bool gover = false;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("QUIT");
            Application.Quit();
        }
    }
    public void gameOver()
    {
        if (!gover)
        {
            gover = true;
            Debug.Log("GAMEOVER");
            Invoke("restart", restartDelay);
        }
    }
    public void completeLevel()
    {
        if (!gover)
        {
            Debug.Log("Level BEATEN");
            completeLevelUI.SetActive(true);
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
