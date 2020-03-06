using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class splashScreenCreator : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(waitFor5Secs());
        changeSplashScreen();
    }

    IEnumerator waitFor5Secs()
    {
        yield return new WaitForSeconds(5);
    }

    void changeSplashScreen()
    {
        SceneManager.LoadScene("SampleScene");
    }
    

}
