using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public AudioSource buttonClick;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("Totalscore"))
            PlayerPrefs.SetInt("Totalscore", 0);

    }

    public void OnStartDown()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Endless Fox Runnner");
    }

}