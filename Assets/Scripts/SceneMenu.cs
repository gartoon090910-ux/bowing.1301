using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene("scen01");

    }

    public void Exit()
    {
        Application.Quit();

    }
}
