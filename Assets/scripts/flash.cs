using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class flash : MonoBehaviour
{
    public GameObject telaFlash;
    public GameObject telaCadastra;
    public Image img;
    public IEnumerator coroutine;
    

    void OnEnable()
    {
        // Define o estado inicial para true e reinicia a corrotina

        coroutine = fla();
        StartCoroutine(coroutine);
    }

    void OnDisable()
    {
        // Garante que a corrotina pare quando o objeto for desativado
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
        }
    }
    // Update is called once per frame
    public IEnumerator fla()
    {
  
        img.color = new Color(1f, 1f, 1f, 0f);
        yield return new WaitForSeconds(0.3f);
        img.color = new Color(1f, 1f, 1f, 1f);
        yield return new WaitForSeconds(0.2f);
        img.color = new Color(255f, 255f, 255f, 255f);
        telaFlash.SetActive(false);
        telaCadastra.SetActive(true);
    }

}