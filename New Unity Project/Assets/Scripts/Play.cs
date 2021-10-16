using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    public void Comecar () {
        animator.SetBool("clickedPlay",true);
        SceneManager.LoadScene("Cena Inicial");
    }
}
