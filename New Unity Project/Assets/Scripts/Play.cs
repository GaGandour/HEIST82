using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    public void jogar()
    {
        StartCoroutine(comecar());
    }
    IEnumerator comecar() {
        animator.SetBool("clickedPlay",true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Cena Inicial");
    }
}
