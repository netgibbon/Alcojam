using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(LoadMenu());
    }

    // Update is called once per frame
    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(12);
        SceneManager.LoadScene("MainMenu");
    }
}