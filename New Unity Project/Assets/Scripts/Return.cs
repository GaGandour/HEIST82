using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{    public void voltar()
    {
        SceneManager.LoadScene("Menu Inicial");
    }
}
