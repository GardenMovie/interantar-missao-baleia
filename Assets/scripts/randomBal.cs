using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class randomBal : MonoBehaviour
{
    public TMP_Text meuTextoTMP;
    public int k;
    [SerializeField] Texture[] sprites;
    [SerializeField] Texture meuSprite;
    public void apareceAleatorio()
    {
        k = Random.Range(0, 70);
        meuSprite = sprites[k];
        gameObject.GetComponent<RawImage>().texture = meuSprite;
        meuTextoTMP.text = k.ToString(); 

    }
}
