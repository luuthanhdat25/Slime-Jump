using UnityEngine;

public class ManagerMenu : MonoBehaviour
{
    public GameObject InputBox;
    public AudioSource Click;

    public void PlayGame()
    {
        Click.Play();
    }
    public void BackToMenu()
    {
        InputBox.SetActive(false);
    }
    public void PlayAudio() 
    {
        Click.Play();
    }

    public void Rank()
    {
        SavingPlayer.Load();
        Click.Play();
    }

    public void QuitGame()
    {
        Click.Play();
        Application.Quit();
    }
}