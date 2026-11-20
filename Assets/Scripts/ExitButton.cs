using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitButton : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("StartScreen");
    }
}