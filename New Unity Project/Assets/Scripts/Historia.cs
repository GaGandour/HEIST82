using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Historia : MonoBehaviour
{
    public GameObject[] buttons;
    public Text[] buttonText;
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
        disableButtons();
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
                enableButtons();
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
                StartCoroutine(derrota());
                break;
            case Status.Sucesso:
                StartCoroutine(vitoria());
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
        caixaDeTexto.GetComponent<textBoxArvore>().sentences = falaAtual.falas.ToArray();
        escolha = -1;
    }


    IEnumerator derrota()
    {
        switch (falaAtual.id)
        {
            case "SanZung Explode":
                GameObject.Find("final celular explode").SetActive(true);
                break;
            case "roubo reverso":
                GameObject.Find("final voce é roubado").SetActive(true);
                break;
            case "Policial":
                GameObject.Find("morte por tiro").SetActive(true);
                break;
            case "demo":
                GameObject.Find("final 7 dias").SetActive(true);
                break;
            case "traido":
                GameObject.Find("final namorada").SetActive(true);
                break;
            case "Nokia 3310":
                GameObject.Find("final nokia").SetActive(true);
                break;
            case "Ele percebeu":
                GameObject.Find("final voce é roubado").SetActive(true);
                break;
            case "pega":
                GameObject.Find("final voce é roubado").SetActive(true);
                break;
            case "desvia":
                GameObject.Find("final voce é roubado").SetActive(true);
                break;
            case "fuga":
                GameObject.Find("final voce é roubado").SetActive(true);
                break;
            case "Naruto":
                GameObject.Find("final naruto").SetActive(true);
                break;
            case "nerf no olho":
            case "diversão com nerf":
            case "Nao encarei":
                GameObject.Find("final nerf").SetActive(true);
                break;
            case "ele me fez de trouxa":
                GameObject.Find("ele me fez de trouxa").SetActive(true);
                break;
            case "assalto reverso":
                GameObject.Find("final voce é roubado").SetActive(true);
                break;     
            case "Olho azul":
                GameObject.Find("final undertale olho azul").SetActive(true);
                break;
            case "Luta de bar":
                GameObject.Find("Luta").SetActive(true);
                break;
            case "taz":
                GameObject.Find("Doido").SetActive(true);
                break;
            case "Atropelou":
                GameObject.Find("Ambulancia_Atropela").SetActive(true);
                break;
            case "conta cara":
                GameObject.Find("Ambulancia_Cara").SetActive(true);
                break;
            case "negado":
                GameObject.Find("Ta_de_saca").SetActive(true);
                break;
            case "nao gostou":
                GameObject.Find("Foi_Embora").SetActive(true);
                break;
            case "magica errada":
                GameObject.Find("Sumiu").SetActive(true);
                break;
            case "aceitou":
                GameObject.Find("Casamento").SetActive(true);
                break;
            case "alcool gel":
                GameObject.Find("Alcool_Gel").SetActive(true);
                break;
        }    
        SceneManager.LoadScene("Derrota");
        
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Vitoria");
    }
    IEnumerator vitoria()
    {
        switch (falaAtual.id)
        {
            case "Breakdance":
                GameObject.Find("final breakdance").SetActive(true);
                break;
            case "Avó da vítima":
                GameObject.Find("final vovó").SetActive(true);
                break;
            case "Intimidou":
                GameObject.Find("final ak47").SetActive(true);
                break;
            case "sair de fininho-s":
                GameObject.Find("final voce é roubado").SetActive(true);
                break;
            case "salvei alguém":
                GameObject.Find("imagem para finais nao especificos").SetActive(true);
                break;
            case "Amigo de infância":
                GameObject.Find("final me da um emprego").SetActive(true);
                break;
            case "defende":
                GameObject.Find("final voce é roubado").SetActive(true);
                break;
            case "ninja":
                GameObject.Find("final corrida ninja").SetActive(true);
                break;
            case "Final Normal":
                GameObject.Find("imagem para finais nao especificos").SetActive(true);
                break;
            case "Famoso":
                GameObject.Find("final famoso na internet").SetActive(true);
                break;
            case "ele aceitou":
                GameObject.Find("Emprego").SetActive(true);
                break;
            case "apaziguar":
                GameObject.Find("imagem para finais nao especificos").SetActive(true);
                break;
            case "Ela joga e sai correndo":
                GameObject.Find("Bolsa").SetActive(true);
                break;
            case "ajuda":
                GameObject.Find("Emprego").SetActive(true);
                break;
            case "F#":
                GameObject.Find("F#").SetActive(true);
                break;
            case "jojo":
                GameObject.Find("final jojo").SetActive(true);
                break;
            case "bebado necessitado":
                GameObject.Find("Muito_dinheiro").SetActive(true);
                break;
            case "gostou":
                GameObject.Find("oferecer bebida").SetActive(true);     
                break;    
        }
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Vitoria");
    }
    IEnumerator flip()
    {
        isAnimating = true;
        bookAnimator.SetBool("flip",true);
        yield return new WaitForSeconds(1f);
        bookAnimator.SetBool("flip",false);
        isAnimating = false;
    }

    void enableButtons()
    {
        for(int j = 0; j < falaAtual.listaDeOpcoes.ToArray().Length; j++)
        {
            buttons[j].SetActive(true);
            buttonText[j].text = falaAtual.listaDeOpcoes[j];
        }
    }

    void disableButtons()
    {
        foreach(Text text in buttonText)
        {
            text.text = "";
        }
        foreach(GameObject button in buttons)
        {
            button.SetActive(false);
        }
    }
}