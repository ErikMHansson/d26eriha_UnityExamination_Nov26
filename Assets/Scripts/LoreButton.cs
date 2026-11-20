using UnityEngine;
using UnityEngine.SceneManagement;
public class LoreButton : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("LoreScene");
    }
}

