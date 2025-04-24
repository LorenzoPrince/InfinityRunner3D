using UnityEngine;
using UnityEngine.SceneManagement;

public class UIPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void exit()
    {
        #if UNITY_EDITOR // Esto funciona dentro del editor
           UnityEditor.EditorApplication.isPlaying = false;
        #else // Esto funciona en un build posta (PC, Android, o lo que sea)
        Application.Quit();
        #endif
    }
}
