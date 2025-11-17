using UnityEngine;
using TMPro;


public class tTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float elipsedTime;
    [SerializeField] GameObject PanelPontu;
    [SerializeField] GameObject PanelFotoTira;
    [SerializeField] GameObject PanelLocalFoto;

    void Update()
    {


        if (elipsedTime > 0)
        {
            elipsedTime -= Time.deltaTime;
        }
        else if (elipsedTime < 0)
        {
            elipsedTime = 0;
            PanelPontu.SetActive(true);
            PanelFotoTira.SetActive(false);
            PanelLocalFoto.SetActive(false);
        }
        int minutes = Mathf.FloorToInt(elipsedTime / 60);
        int seconds = Mathf.FloorToInt(elipsedTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
