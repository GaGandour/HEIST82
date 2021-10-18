using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Ramos;

public class Historia : MonoBehaviour
{
    private Ramos arvore;
    private Fala falaAtual;
    private int escolha;
    private int probabilidade;
    private Random rnd;
    private void Start() {
        escolha = -1;
        arvore = gameObject.GetComponent<Ramos>() as Ramos;
        falaAtual = arvore.historia;
        rnd = new Random();
    }
    public void IrParaOProximo () {
        switch (falaAtual.status)
        {
            case Status.Falha:
                break;
            case Status.Sucesso:
                break;
            case Status.Nulo:
                switch (falaAtual.proximo)
                {
                    case Proximo.Escolha:
                        // Animacao();
                        break;
                    case Proximo.Probabilistico:
                        //Animacao();
                        probabilidade = rnd.Next(1,100);
                        for (int i = 0; i < 5; i++)
                        {
                            if (probabilidade <= falaAtual.listaDeProbabilidades[i])
                            {
                                escolha = i;
                                break;
                            }
                            else
                            {
                                probabilidade -= falaAtual.listaDeProbabilidades[i];
                            }
                        }
                        break;
                }
                falaAtual = falaAtual.listaDeRamos[escolha];
                break;
        }
    }
}