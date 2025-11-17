using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class changeLoc : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI lat;
    [SerializeField] TextMeshProUGUI lon;
    [SerializeField] Button but1;
    [SerializeField] Button but2;
    [SerializeField] Button but3;
    [SerializeField] Button but4;
    [SerializeField] Button but5;
    [SerializeField] GameObject panelEnt;
    //[SerializeField] GameObject panelSai;
    [SerializeField] GameObject panelArg;
    [SerializeField] GameObject panelSC;
    [SerializeField] GameObject panelBah;
    [SerializeField] GameObject panelSP;
    [SerializeField] GameObject panelPA;

    public void deSet()
    {
        panelArg.SetActive(false);
        panelSC.SetActive(false);
        panelBah.SetActive(false);
        panelSP.SetActive(false);
        panelPA.SetActive(false);
    }
    public void setArgentina()
    {
        lat.text = "42º 46' S";
        lon.text = "65º 02' W";
        deSet();
        panelArg.SetActive(true);
        panelEnt.SetActive(false);
        
    }
    public void setSanCat()
    {
        //1
        lat.text = "28º 14' S";
        lon.text = "48º 40' W";
        deSet();
        panelSC.SetActive(true);
        panelEnt.SetActive(false);
        
    }
    public void setBah()
    {
        //2
        lat.text = "12º 34' S";
        lon.text = "38º 00' W";
        deSet();
        panelBah.SetActive(true);
        panelEnt.SetActive(false);
        
    }
    public void setSP()
    {
        //3
        lat.text = "23º 46' S";
        lon.text = "45º 21' W";
        deSet();
        panelSP.SetActive(true);
        panelEnt.SetActive(false);
        
    }

    public void setPenAnt()
    {
        lat.text = "67° 21' S";
        lon.text = "61° 12' W";
        deSet();
        panelPA.SetActive(true);
        panelEnt.SetActive(false);
       
    }
    public void setLoc()
    {
        but1 = GetComponent<Button>();
        but2 = GetComponent<Button>();
        but3 = GetComponent<Button>();
        but4 = GetComponent<Button>();
        but5 = GetComponent<Button>();

        but1.onClick.AddListener(setBah);
        but2.onClick.AddListener(setSP);
        but3.onClick.AddListener(setSanCat);
        but4.onClick.AddListener(setArgentina);
        but5.onClick.AddListener(setPenAnt);
    }

}
