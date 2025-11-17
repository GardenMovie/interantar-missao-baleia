using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fotoCauda : MonoBehaviour
{
    int k;
    float te, ti;
    public int xRandom, yRandom;
    public bool stateFoto = true;
    public RawImage img;
    public IEnumerator coroutine;
    [SerializeField] Texture[] sprites;
    [SerializeField] Texture meuSprite;
    private Button btn; // Referência privada para o botão

    void Awake() // Use Awake para obter a referência do componente
    {
        img = GetComponent<RawImage>();
        btn = GetComponent<Button>();
    }

    void OnEnable()
    {
        // Define o estado inicial para true e reinicia a corrotina
        stateFoto = true;
        coroutine = WaitAndPrint();
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

    public IEnumerator WaitAndPrint()
    {
        while (stateFoto)
        {
            //k = Random.Range(0, sprites.Length); // Use sprites.Length
            te = Random.Range(0.1f, 4.0f);
            ti = Random.Range(0.3f, 1.5f);
            xRandom = Random.Range(100, 1300);
            yRandom = Random.Range(100, 550);
            if (btn != null) btn.interactable = false;
            transform.position = new Vector2(xRandom, yRandom);
            meuSprite = sprites[0];
            img.texture = meuSprite;

            //transform.position = new Vector2(1000, 1000);
            yield return new WaitForSeconds(ti);

            meuSprite = sprites[1];
            img.texture = meuSprite;

            yield return new WaitForSeconds(ti);

           
            if (btn != null) btn.interactable = true;

            meuSprite = sprites[2];
            img.texture = meuSprite;

            yield return new WaitForSeconds(ti);

            meuSprite = sprites[3];
            img.texture = meuSprite;

            if (btn != null) btn.interactable = false;
            yield return new WaitForSeconds(ti);
            transform.position = new Vector2(1000, 1000);
            yield return new WaitForSeconds(te);
        }
    }
}