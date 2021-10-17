using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textBox : MonoBehaviour
{
    public Text textDisplay;
    public string[] sentences;
    private int index;
    public float typeSpeed;
    void Start()
    {
        StartCoroutine(textTyper());
    }
    IEnumerator textTyper()
     {
        foreach(char letter in sentences[index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(typeSpeed);
        }
    }

    public void nextSentence()
    {
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(textTyper());
        }
        else{
            textDisplay.text = "";
        }
    }
}
