using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject About;
    public GameObject Name;
    public float Timer = 15f;
    private MessageAnimations _animator;
    void Start()
    {   
        _animator = GameObject.Find("Panel").GetComponent<MessageAnimations>();
        _animator.StartScence();
        About.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer < 0) Timer = 0;
        if(Timer > 0) Timer -= Time.deltaTime;
        if(Timer <=3){
            _animator.EndScence();
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
        SceneManager.LoadScene(1);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        SceneManager.LoadScene(2);
    }
}
