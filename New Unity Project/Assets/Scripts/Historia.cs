using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Historia : MonoBehaviour
{
    private Ramos arvore;
    private Fala falaAtual;
    private int escolha;
    private int probabilidade;
    private void Start() {
        escolha = -1;
        arvore = gameObject.GetComponent<Ramos>() as Ramos;
        falaAtual = arvore.historia;
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
                        // Animacao();
                        break;
                    case Proximo.Probabilistico:
                        // Animacao();
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
    }
}