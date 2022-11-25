using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    //Order of Scenes
    private int currentScene;
    private int nextScene;
    private int prevScene;

    //How many seconds till carnage
    public float delayDelta = 0f;
    //Main Scene
    public string Menu = "Menu";
    

    //Time that have passed
    private float timeElapsed;


    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        prevScene = SceneManager.GetActiveScene().buildIndex - 1;

    }
    void Update()
    {
        //Variable moves with the power of time in seconds.
        timeElapsed += Time.deltaTime;

        //Loads the home screen if variable is greater than the given time.
        if (timeElapsed > delayDelta)
        {
            SceneManager.LoadScene(Menu);
            Debug.Log("Done");
        }
    }
    public void LoadScene(string scenName)
    {
        SceneManager.LoadScene(scenName);

    }
}
