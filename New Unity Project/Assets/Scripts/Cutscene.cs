using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    int numero;
    public GameObject canvas;
    public GameObject imagem1;
    public GameObject imagem2;
    public GameObject imagem3;
    public GameObject imagem4;
    public GameObject imagem5;
    GameObject imagemAtual;

    Vector3 posicao = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        numero = 1;
        imagemAtual = Instantiate(imagem1, posicao, Quaternion.identity);
        imagemAtual.transform.localScale = new Vector3(237,237,1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 1 && numero == 1) {
            Destroy(imagemAtual);
            imagemAtual = Instantiate(imagem2, posicao, Quaternion.identity);
            imagemAtual.transform.localScale = new Vector3(237,237,1);
            numero++;
        }
        if (Time.time > 2 && numero == 2) {
            Destroy(imagemAtual);
            imagemAtual = Instantiate(imagem3, posicao, Quaternion.identity);
            imagemAtual.transform.localScale = new Vector3(237,237,1);
            numero++;
        }
        if (Time.time > 3 && numero == 3) {
            Destroy(imagemAtual);
            imagemAtual = Instantiate(imagem4, posicao, Quaternion.identity);
            imagemAtual.transform.localScale = new Vector3(237,237,1);
            numero++;
        }
        if (Time.time > 4 && numero == 4) {
            Destroy(imagemAtual);
            imagemAtual = Instantiate(imagem5, posicao, Quaternion.identity);
            imagemAtual.transform.localScale = new Vector3(237,237,1);
            numero++;
        }
    }
}
