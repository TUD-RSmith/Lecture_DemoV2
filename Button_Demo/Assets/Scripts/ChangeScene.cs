using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string URL = "https://github.com/TUD-RSmith/Lecture_Demo";
    public void GoToSene1()
    {
        SceneManager.LoadScene("scene1");
    }

    public void GoToSene2()
    {
        SceneManager.LoadScene("scene2");
    }

    public void loadUrl()
    {
        Application.OpenURL(URL);
    }
}
