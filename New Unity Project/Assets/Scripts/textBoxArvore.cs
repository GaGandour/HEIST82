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
    public float alpha;
    private SpriteRenderer m_SpriteRenderer;

    public bool isTyping;

    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void enterDialogue()
    {
        StartCoroutine(textTyper());
    }
    IEnumerator textTyper()
     {
        isTyping = true;
        foreach(char letter in sentences[index].ToCharArray()){
            textDisplay.text += letter;
            yield return new WaitForSeconds(typeSpeed);
        }
        isTyping = false;
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
    public void openBox()
    {
        m_SpriteRenderer.color += new Color (0, 0, 0, alpha);
    }

    public void closeBox()
    {
        textDisplay.text = "";
        m_SpriteRenderer.color -= new Color (0, 0, 0, alpha);
    }
}
