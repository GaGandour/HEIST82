using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Animator coolKidA;
    public Transform coolKidT;
    public Animator skepticalKidA;
    public Transform skepticalKidT;
    public Animator expressiveKidA;
    public Transform expressiveKidT;
    public Animator oldManA;
    public Transform oldManT;
    public Animator Room;
    public textBox chat;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(animator());
    }

    // Update is called once per frame
    IEnumerator animator()
    {
        //inicio da cena
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        yield return new WaitForSeconds(0.3f);
        //fala com netos
        chat.openBox();
        chat.enterDialogue();
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        while (chat.isTyping)
        {
          yield return null;
        }
        chat.nextSentence();
        while (chat.isTyping)
        {
          yield return null;
        }
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        chat.nextSentence();
        while (chat.isTyping)
        {
          yield return null;
        }
        //pisca a luz
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        chat.closeBox();
        Room.SetBool("flickering",true);
        yield return new WaitForSeconds(0.3f);
        //falas antes de faltar a luz
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        chat.openBox();
        chat.nextSentence();
        while (chat.isTyping)
        {
          yield return null;
        }
        //falta luz
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        Room.SetBool("lightsOut",true);
        chat.closeBox();
        yield return new WaitForSeconds(0.3f);
        //Vo fala com os netos
        chat.openBox();
        //Vo vai ate estante
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        oldManA.SetBool("walking",true);
        yield return new WaitForSeconds(0.2f);
        for(int i=0; i<70; i++)
        {
            yield return new WaitForSeconds(0.1f);
            oldManT.position = new Vector3(oldManT.position.x - 2.67f, oldManT.position.y + 0.32f, oldManT.position.z);
        }
        oldManA.SetBool("walking",false);
        //Vo pega livro
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        yield return new WaitForSeconds(0.3f);
        oldManA.SetBool("handRaised",true);
        yield return new WaitForSeconds(1f);
        //Vo guarda livro
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        yield return new WaitForSeconds(0.3f);
        oldManA.SetBool("handRaised",false);
        yield return new WaitForSeconds(1f);
        //Vo retorna a sua posicao inicial
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        oldManT.localScale = new Vector3(-1*oldManT.localScale.x, 1*oldManT.localScale.y, 1*oldManT.localScale.z);
        oldManA.SetBool("walking",true);
        yield return new WaitForSeconds(0.2f);
        for(int i=0; i<70; i++)
        {
            yield return new WaitForSeconds(0.1f);
            oldManT.position = new Vector3(oldManT.position.x + 2.67f, oldManT.position.y - 0.32f, oldManT.position.z);
        }
        oldManA.SetBool("walking",false);
        yield return new WaitForSeconds(0.2f);
        oldManT.localScale = new Vector3(-1*oldManT.localScale.x, 1*oldManT.localScale.y, 1*oldManT.localScale.z);
    }
}
