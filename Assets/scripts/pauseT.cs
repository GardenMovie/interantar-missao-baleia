using UnityEngine;

public class pauseT : MonoBehaviour
{
    
    public void Pausar()
    {
        Time.timeScale = 0;

    }

    public void Acontecer()
    {
        Time.timeScale = 1;
        
    }
}
