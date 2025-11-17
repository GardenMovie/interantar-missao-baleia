using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
public class SelectBaleia : MonoBehaviour
{
    public int pontuacao =0;
    public int[] vetPont = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0};
    public int auxPont;
    public int k = 0;
    public int valRealBaleia;
    public GameObject[] baleias = new GameObject[70];
    public GameObject[] imageValSel;
    public int[] vecDisAp = { 0, 0, 0, 0, 1 };
    public int[] vecDisNaoAp = { 0, 0, 0, 1};
    public TMP_Dropdown Drop1;
    public TMP_Dropdown Drop2;
    public TMP_Dropdown Drop3;
    public TMP_Dropdown Drop4;
    public Button butCadas;
    public Button butIden;
    public Button butBusc;
    Button bntIden;
    Button bntCadas;
    Button bntBusc ;
    [SerializeField] TextMeshProUGUI ponFin;

    /*
    void Awake() // Use Awake para obter a referência do componente
    {
        
    }*/

    void OnEnable()
    {
        
        valRealBaleia = Random.Range(0, 70);
        imageValSel[valRealBaleia].SetActive(true);
        bntIden = butIden.GetComponent<Button>();
        bntCadas = butCadas.GetComponent<Button>();
        bntBusc = butBusc.GetComponent<Button>();
        bntIden.onClick.AddListener(pontuaBalApa);
        bntCadas.onClick.AddListener(pontuaBalNaoApa);
        bntBusc.onClick.AddListener(filtro);
    }

    void OnDisable()
    {
   
        auxPont = 0;
        for (int i = 0; i < 15; i++)
        {
            auxPont += vetPont[i];
        }
        pontuacao = auxPont;
        ponFin.text = pontuacao.ToString();
        for (int i = 0; i < vecDisAp[4]; i++)
        {
            baleias[vecDisAp[i]].SetActive(false);
            //vecDisAp[i] = -1;
        }
        k++;

    }
    

       
    public void pontuaBalNaoApa()
    {
        
        for (int i = 0; i < vecDisNaoAp[3]; i++)
        {
            if (valRealBaleia == vecDisNaoAp[i])
            {
                vetPont[k]= 2;
                
            }
        }
        imageValSel[valRealBaleia].SetActive(false);
    }


    public void pontuaBalApa()
    {
        for (int i = 0; i < vecDisAp[4]; i++)
        {
            if (valRealBaleia == vecDisAp[i])
            {
                vetPont[k] = 1;

            }
        }
        imageValSel[valRealBaleia].SetActive(false);
    }

    public void filtro()
    {

        int index1 = Drop1.value;
        string textoSelecionado1 = Drop1.options[index1].text;

        int index2 = Drop2.value;
        string textoSelecionado2 = Drop2.options[index2].text;

        int index3 = Drop3.value;
        string textoSelecionado3 = Drop3.options[index3].text;

        int index4 = Drop4.value;
        string textoSelecionado4 = Drop4.options[index4].text;

        if (textoSelecionado1 == "Muito áspera")
        {
            for (int i = 0; i < vecDisAp[4]; i++)
            {
                baleias[vecDisAp[i]].SetActive(false);
                //vecDisAp[i] = -1;
            }
            /*for (int i = 0;i < vecDisNaoAp[3]; i++)
            {
                vecDisNaoAp[i] = -1;
            }*/
            if (textoSelecionado2 == "1A")
            {               
                if (textoSelecionado3 == "Aguda")
                {                  
                    if (textoSelecionado4 == "Grande")
                    { 
                        baleias[31].SetActive(true);
                        vecDisAp[0] = 31;
                        vecDisAp[4] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    } 
                    else 
                    {

                    }

                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else 
                    {

                    }
                }

            }
            else if (textoSelecionado2 == "1B")
            {

                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        
                        baleias[12].SetActive(true);
                        vecDisAp[0] = 12;
                        vecDisAp[4] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }


            }
            else if (textoSelecionado2 == "2")
            {

                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {
                        baleias[49].SetActive(true);
                        vecDisAp[0] = 49;
                        vecDisAp[4] = 1;
                    }
                }

            }
            else if (textoSelecionado2 == "3")
            {

                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        baleias[22].SetActive(true);
                        vecDisAp[0] = 22;
                        vecDisAp[4] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }

            }
            else if (textoSelecionado2 == "4")
            {

                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }

            }
            else if (textoSelecionado2 == "5")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
            }

        } 
        else if (textoSelecionado1 == "Áspera")
        {
            for (int i = 0; i < vecDisAp[4]; i++)
            {
                baleias[vecDisAp[i]].SetActive(false);
                //vecDisAp[i] = -1;
            }
            /*for (int i = 0;i < vecDisNaoAp[3]; i++)
            {
                vecDisNaoAp[i] = -1;
            }*/
            if (textoSelecionado2 == "1A")
            {

                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        baleias[47].SetActive(true);
                        baleias[48].SetActive(true);
                        baleias[36].SetActive(true);
                        vecDisAp[0] = 47;
                        vecDisAp[1] = 48;
                        vecDisAp[2] = 36;
                        vecDisNaoAp[0]= 59;
                        vecDisAp[4] = 3;
                        vecDisNaoAp[3] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[20].SetActive(true);
                        baleias[30].SetActive(true);
                        baleias[44].SetActive(true);
                        vecDisAp[0] = 20;
                        vecDisAp[1] = 30;
                        vecDisAp[2] = 44;
                        vecDisAp[4] = 3;
                    }
                    else
                    {
                        baleias[17].SetActive(true);
                        baleias[26].SetActive(true);
                        vecDisAp[0] = 17;
                        vecDisAp[1] = 26;
                        vecDisAp[4] = 2;
                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        //baleias[58].SetActive(true);
                        vecDisNaoAp[0] = 58;
                        vecDisNaoAp[3] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        
                    }
                    else
                    {
                        //baleias[55].SetActive(true);
                        vecDisNaoAp[0] = 55;
                        vecDisNaoAp[3] = 1;

                    }
                }


            }
            else if (textoSelecionado2 == "1B")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        baleias[15].SetActive(true);
                        vecDisAp[0] = 15;
                        vecDisNaoAp[0] = 61;
                        vecDisNaoAp[3] = 1;
                        vecDisAp[4] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[6].SetActive(true);
                        vecDisAp[0] = 6;
                        vecDisAp[4] = 1;
                    }
                    else
                    {
                        baleias[40].SetActive(true);
                        vecDisAp[0] = 40;
                        vecDisAp[4] = 1;
                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        //baleias[66].SetActive(true);
                        vecDisNaoAp[0] = 66;
                        vecDisNaoAp[3] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[46].SetActive(true);
                        vecDisAp[0] = 46;
                        vecDisAp[4] = 1;
                        vecDisNaoAp[0] = 65;
                        vecDisNaoAp[1] = 66;
                        vecDisNaoAp[3] = 2;
                        //baleias[65].SetActive(true);
                    }
                    else
                    {

                    }
                }
            }
            else if (textoSelecionado2 == "2")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[28].SetActive(true);
                        vecDisAp[0] = 28;
                        vecDisAp[4] = 1;
                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        vecDisNaoAp[0] = 62;
                        vecDisNaoAp[3] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[16].SetActive(true);
                        baleias[18].SetActive(true);
                        vecDisAp[0] = 16;
                        vecDisAp[1] = 18;
                        vecDisAp[4] = 2;
                    }
                    else
                    {

                    }
                }
            }
            else if (textoSelecionado2 == "3")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        baleias[2].SetActive(true);
                        vecDisAp[0] = 2;
                        vecDisAp[4] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[38].SetActive(true);
                        vecDisAp[0] = 38;
                        vecDisAp[4] = 1;
                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {
                        baleias[56].SetActive(true);
                        vecDisNaoAp[0] = 56;
                        vecDisNaoAp[3] = 1;
                    }
                }
            }
            else if (textoSelecionado2 == "4")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        //baleias[63].SetActive(true);
                        vecDisNaoAp[0] = 63;
                        vecDisNaoAp[3] = 1;
                    }
                    else
                    {
                        baleias[10].SetActive(true);
                        vecDisAp[0] = 10;
                        vecDisAp[4] = 1;
                    }
                }
            }
            else if (textoSelecionado2 == "5")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[14].SetActive(true);
                        vecDisAp[0] = 14;
                        vecDisAp[4] = 1;
                    }
                    else
                    {
                        baleias[29].SetActive(true);
                        vecDisAp[0] = 29;
                        vecDisAp[4] = 1;
                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        //baleias[60].SetActive(true);
                        vecDisNaoAp[0] = 60;
                        vecDisNaoAp[3] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
            }



        }
        else if (textoSelecionado1 == "Pouco áspera")
        {
            for (int i = 0; i < vecDisAp[4]; i++)
            {
                baleias[vecDisAp[i]].SetActive(false);
                //vecDisAp[i] = -1;
            }
            /*for (int i = 0;i < vecDisNaoAp[3]; i++)
            {
                vecDisNaoAp[i] = -1;
            }*/
            if (textoSelecionado2 == "1A")
            {
                if(textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        
                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        
                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        baleias[11].SetActive(true);
                        vecDisAp[0] = 11;
                        vecDisAp[4] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[19].SetActive(true);
                        baleias[27].SetActive(true);
                        vecDisAp[0] = 19;
                        vecDisAp[1] = 27;
                        vecDisAp[4] = 2;
                    }
                    else
                    {
                        baleias[35].SetActive(true);
                        vecDisAp[0] = 35;
                        vecDisAp[4] = 1;
                    }
                }
            }
            else if (textoSelecionado2 == "1B")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[21].SetActive(true);
                        vecDisAp[0] = 21;
                        vecDisAp[4] = 1;
                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
            }
            else if (textoSelecionado2 == "2")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[8].SetActive(true);
                        baleias[43].SetActive(true);
                        vecDisAp[0] = 8;
                        vecDisAp[1] = 43;
                        vecDisAp[4] = 2;
                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        baleias[25].SetActive(true);
                        vecDisAp[0] = 25;
                        vecDisAp[4] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[42].SetActive(true);
                        vecDisAp[0] = 42;
                        vecDisAp[4] = 1;
                        //vecDisAp[0] =69;
                        //rever valor
                        vecDisNaoAp[0] = 50;
                        vecDisNaoAp[1] = 69;
                        vecDisNaoAp[3] = 2;
                    }
                    else
                    {
                        baleias[23].SetActive(true);
                        vecDisAp[0] = 23;
                        vecDisAp[4] = 1;
                    }
                }
            }
            else if (textoSelecionado2 == "3")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {
                        baleias[24].SetActive(true);
                        vecDisAp[0] = 24;
                        vecDisAp[4] = 1;
                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {
                        baleias[45].SetActive(true);
                        baleias[33].SetActive(true);
                        vecDisAp[0] = 45;
                        vecDisAp[1] = 33;
                        vecDisAp[4] = 2;
                    }
                }
            }
            else if (textoSelecionado2 == "4")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        baleias[9].SetActive(true);
                        vecDisAp[0] = 9;
                        vecDisAp[4] = 1;
                        //baleias[64].SetActive(true);
                        //vecDisAp[0] = 64;
                        vecDisNaoAp[0] = 64;
                        vecDisNaoAp[3] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
            }
            else if (textoSelecionado2 == "5")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        
                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[0].SetActive(true);
                        vecDisAp[0] = 0;
                        vecDisAp[4] = 1;
                    }
                    else
                    {
                        baleias[1].SetActive(true);
                        vecDisAp[0] = 1;
                        vecDisAp[4] = 1;
                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
            }


        }
        else if (textoSelecionado1 == "Suave")
        {

            for (int i = 0; i < vecDisAp[4]; i++)
            {
                baleias[vecDisAp[i]].SetActive(false);
               // vecDisAp[i] = -1;
            }
            /*for (int i = 0;i < vecDisNaoAp[3]; i++)
            {
                vecDisNaoAp[i] = -1;
            }*/
            if (textoSelecionado2 == "1A")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        baleias[34].SetActive(true);
                        vecDisAp[0] = 34;
                        vecDisAp[4] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[37].SetActive(true);
                        baleias[13].SetActive(true);
                        vecDisAp[0] = 37;
                        vecDisAp[1] = 13;
                        vecDisAp[4] = 2;
                        //baleias[57].SetActive(true);
                        vecDisNaoAp[0] = 57;
                        vecDisNaoAp[3] = 1;
                    }
                    else
                    {
                        baleias[5].SetActive(true);
                        vecDisAp[0] = 5;
                        vecDisAp[4] = 1;
                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        
                    }
                    else
                    {

                    }
                }
            }
            else if (textoSelecionado2 == "1B")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[4].SetActive(true);
                        vecDisAp[0] = 4;
                        vecDisAp[4] = 1;

                        vecDisNaoAp[0] = 51;
                        vecDisNaoAp[3] = 1;
                    }
                    else
                    {
                        baleias[32].SetActive(true);
                        vecDisAp[0] = 32; 
                        vecDisAp[4] = 1;
                    }
                }
            }
            else if (textoSelecionado2 == "2")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {
                        //baleias[53].SetActive(true);
                        //vecDisAp[0] = 53;
                        //vecDisAp[4] = 1;
                        vecDisNaoAp[0] = 53;
                        vecDisNaoAp[3] = 1;
                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        
                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
            }
            else if (textoSelecionado2 == "3")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {
                        baleias[7].SetActive(true);
                        vecDisAp[0] = 7;
                        vecDisAp[4] = 1;
                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
            }
            else if (textoSelecionado2 == "4")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {
                        baleias[39].SetActive(true);
                        vecDisAp[0] = 39;
                        vecDisAp[4] = 1;
                    }
                    else
                    {

                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {

                    }
                }
            }
            else if (textoSelecionado2 == "5")
            {
                if (textoSelecionado3 == "Aguda")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {
                        baleias[41].SetActive(true);
                        baleias[3].SetActive(true);
                        vecDisAp[0] = 41;
                        vecDisAp[1] = 3;
                        vecDisAp[4] = 2;
                    }
                }
                else if (textoSelecionado3 == "Arredondada")
                {
                    if (textoSelecionado4 == "Grande")
                    {

                    }
                    else if (textoSelecionado4 == "Médio")
                    {

                    }
                    else
                    {
                        //baleias[54].SetActive(true);
                        //baleias[52].SetActive(true);
                        //vecDisAp[0] = 54;
                        //vecDisAp[1] = 52;
                        //vecDisAp[4] = 2;
                        vecDisNaoAp[0] = 54;
                        vecDisNaoAp[1] = 52;
                        vecDisNaoAp[3] = 2;
                    }
                }
            }



        }



    }


}
