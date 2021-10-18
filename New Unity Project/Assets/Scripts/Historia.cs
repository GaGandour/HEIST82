using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Ramos;

public class Historia : MonoBehaviour
{
    private Ramos arvore;
    private Fala falaAtual;
    private void Start() {
        arvore = gameObject.GetComponent<Ramos>() as Ramos;
        falaAtual = arvore.historia;
    }
    public void IrParaOProximo () {
        animator.SetBool("clickedPlay",true);
        SceneManager.LoadScene("Cena Inicial");
    }
}
