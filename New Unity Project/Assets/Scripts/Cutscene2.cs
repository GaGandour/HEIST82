using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene2 : MonoBehaviour
{
    public GameObject balaoDeTexto;
    private GameObject balaoDeTextoAtual;
    private GameObject imagemAtual;
    public GameObject img1;
    public GameObject img2;
    private Vector3 posicao;
    private Vector3 posicaoTexto;
    private Vector3 escalaImagem;
    private Vector3 escalaTexto;
    private int n;
    void Start()
    {
        escalaImagem = new Vector3(265,265,1);
        escalaTexto = new Vector3(260,260,1);
        n = 1;
        posicao = new Vector3(0,0,0);
        posicaoTexto = new Vector3(0,-110,0);
        imagemAtual = Instantiate(img1, posicao, Quaternion.identity);
        imagemAtual.transform.localScale = escalaImagem;
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            switch(n)
            {
                case 1:
                    Destroy(imagemAtual);
                    imagemAtual = Instantiate(img1, posicao, Quaternion.identity);
                    imagemAtual.transform.localScale = escalaImagem;
                    print("oi");
                    break;
                case 2:
                    Destroy(imagemAtual);
                    imagemAtual = Instantiate(img2, posicao, Quaternion.identity);
                    imagemAtual.transform.localScale = escalaImagem;
                    balaoDeTextoAtual = Instantiate(balaoDeTexto, posicaoTexto, Quaternion.identity);
                    balaoDeTextoAtual.transform.localScale = escalaTexto;
                    balaoDeTextoAtual.GetComponent<SpriteRenderer>().sortingOrder = 1;
                    balaoDeTextoAtual.transform.Find("Canvas").transform.Find("Text").GetComponent<UnityEngine.UI.Text>().text = "oi";
                    balaoDeTextoAtual.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
                    print("oibalaodetexto");
                    break;
                default:
                    break;
            }
            print("oiswitch");
            n++;
        }
    }
}
