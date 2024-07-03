using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static bool isWin;
    public GameObject gameOverScreen;
    private void Awake()
    {
        isWin = false;
    }

    void Update()
    {
        if (isWin)
            gameOverScreen.SetActive(true);
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
