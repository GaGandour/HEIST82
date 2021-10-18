using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        oldManA.SetBool("talking",true);
        chat.enterDialogue();
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
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
        expressiveKidA.SetBool("isSurprised",true);
        oldManA.SetBool("talking",false);
        chat.closeBox();
        Room.SetBool("flickering",true);
        yield return new WaitForSeconds(0.3f);
        //falas antes de faltar a luz
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        oldManA.SetBool("talking",true);
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
        oldManA.SetBool("talking",false);
        chat.closeBox();
        yield return new WaitForSeconds(0.3f);
        //Vo fala com os netos
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        chat.openBox();       
        chat.nextSentence(); 
        oldManA.SetBool("talking",true);
        while (chat.isTyping)
        {
          yield return null;
        }
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }      
        chat.nextSentence(); 
        oldManA.SetBool("talking",false);
        expressiveKidA.SetBool("isSurprised",false);
        expressiveKidA.SetBool("isMad",true);
        while (chat.isTyping)
        {
          yield return null;
        }
        
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }     
        oldManA.SetBool("talking",true);
        chat.nextSentence(); 
        while (chat.isTyping)
        {
          yield return null;
        }
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }     
        oldManA.SetBool("talking",false);
        expressiveKidA.SetBool("isMad",false);
        expressiveKidA.SetBool("isHappy",true);
        chat.nextSentence(); 
        while (chat.isTyping)
        {
          yield return null;
        }
     
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }     
        oldManA.SetBool("talking",true);
        chat.nextSentence(); 
        while (chat.isTyping)
        {
          yield return null;
        }
        oldManA.SetBool("talking",false);
        //Vo vai ate estante
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        chat.closeBox();
        oldManA.SetBool("walking",true);
        yield return new WaitForSeconds(0.2f);
        for(int i=0; i<70; i++)
        {
            yield return new WaitForSeconds(0.1f);
            oldManT.position = new Vector3(oldManT.position.x - 2.67f, oldManT.position.y + 0.32f, oldManT.position.z);
        }
        oldManA.SetBool("walking",false);

        //fala
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }     
        chat.openBox();
        oldManA.SetBool("talking",true);
        chat.nextSentence(); 
        while (chat.isTyping)
        {
          yield return null;
        }
        oldManA.SetBool("talking",false);
        
        
        //Vo pega livro
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        chat.closeBox();
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
        //fala
        chat.openBox();
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }     
        oldManA.SetBool("talking",true);
        chat.nextSentence(); 
        while (chat.isTyping)
        {
          yield return null;
        }
        oldManA.SetBool("talking",false);
        while (!Input.GetKeyDown(KeyCode.Space))
        {
          yield return null;
        }
        chat.closeBox();
        SceneManager.LoadScene("Cutscene 2");
    }
}
