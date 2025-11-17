using UnityEngine;
using UnityEngine.SceneManagement;

public class loadBack : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadMe()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
