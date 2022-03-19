using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using IJunior.TypedScenes;

public class PreviewScenceManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject About;
    public GameObject Name;
    public float Timer = 15f;
    public Animator _panelAnimator;
    public Animator _panelText;
    
    void Start()
    {   
       
        About.SetActive(true);
        _panelAnimator.SetTrigger("Start"); 
        _panelText.SetTrigger("StartText");
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer < 0) Timer = 0;
        if(Timer > 0) Timer -= Time.deltaTime;
        if(Timer <=5){
            _panelAnimator.SetTrigger("End"); 
            _panelText.SetTrigger("EndText");
        }       
        if(Timer == 0)
        {
           ViewName();
           StartCoroutine(NextScence());
        }
    }

    void ViewName(){
        
        About.SetActive(false);
        Name.SetActive(true);
    }
    IEnumerator NextScence(){
        yield return new WaitForSeconds(5f);
        //SceneManager.LoadScene(1);
        Level_1.Load();
    }
   
}
