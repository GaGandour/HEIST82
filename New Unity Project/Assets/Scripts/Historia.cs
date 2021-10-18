using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Historia : MonoBehaviour
{
    public GameObject caixaDeTexto;
    private Ramos arvore;
    private Fala falaAtual;
    private int escolha;
    private int probabilidade;
    private bool isAnimating;
    public Animator bookAnimator;
    private void Start() {
        escolha = -1;
        arvore = gameObject.GetComponent<Ramos>() as Ramos;
        falaAtual = arvore.historia;
        caixaDeTexto.GetComponent<textBoxArvore>().sentences = falaAtual.falas.ToArray();
        
    }
    private void Update() {
        if (Input.GetKeyDown("space") && !caixaDeTexto.GetComponent<textBoxArvore>().isTyping && !isAnimating)
        {
            Falar();
        }
    }
    public void Escolher (int i) {
        escolha = i;
        //sumir os botao
        IrParaOProximo();
    }
    public void Falar () {
        if (caixaDeTexto.GetComponent<textBoxArvore>().index == falaAtual.falas.ToArray().Length)
        {
            caixaDeTexto.GetComponent<textBoxArvore>().closeBox();
            if (falaAtual.proximo == Proximo.Probabilistico || falaAtual.proximo == Proximo.NDA)
            {
                IrParaOProximo();
            }
            else if (falaAtual.proximo == Proximo.Escolha)
            {
                // aparecer os botoes
            }
        }
        else if (caixaDeTexto.GetComponent<textBoxArvore>().index == 0) 
        {
            caixaDeTexto.GetComponent<textBoxArvore>().openBox();
            caixaDeTexto.GetComponent<textBoxArvore>().enterDialogue();
        }
        else if (caixaDeTexto.GetComponent<textBoxArvore>().index < falaAtual.falas.ToArray().Length)
            caixaDeTexto.GetComponent<textBoxArvore>().nextSentence();
    }
    public void IrParaOProximo () {
        switch (falaAtual.status)
        {
            case Status.Falha:
                // Perdeu()
                break;
            case Status.Sucesso:
                // Ganhou()
                break;
            case Status.Nulo:
                switch (falaAtual.proximo)
                {
                    case Proximo.Escolha:
                        StartCoroutine(flip());
                        break;
                    case Proximo.Probabilistico:
                        StartCoroutine(flip());
                        probabilidade = Random.Range(0, 100);
                        for (int i = 0; i < 5; i++)
                        {
                            if (probabilidade <= falaAtual.listadeProbabilidades[i])
                            {
                                escolha = i;
                                break;
                            }
                            else
                            {
                                probabilidade -= falaAtual.listadeProbabilidades[i];
                            }
                        }
                        break;
                }
                falaAtual = falaAtual.listaDeRamos[escolha];
                break;
        }
        caixaDeTexto.GetComponent<textBoxArvore>().index = 0;
        escolha = -1;
    }

    IEnumerator flip()
    {
        isAnimating = true;
        bookAnimator.SetBool("flip",true);
        yield return new WaitForSeconds(1f);
        bookAnimator.SetBool("flip",false);
        isAnimating = false;
    }
}