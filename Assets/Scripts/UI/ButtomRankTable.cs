using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtomRankTable : MonoBehaviour
{
    public AudioSource Click;
    public void PlayAgain()
    {
        Click.Play();
        InputPlayer.Disappear = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        Click.Play();
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

  

}
