using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class EndScenceLoad : MonoBehaviour
{
    public float TimeToEndScence = 50f;
    public bool _isTriggerd = false;
    public Animator Anim;
    void Start()
    {
        
    } 
    private void Update() {
        if(_isTriggerd == true){
            TimeToEndScence -= Time.deltaTime;
        }
        if(TimeToEndScence <=0){
            Anim.SetTrigger("Fade_Out");
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        _isTriggerd = true;
    }
   
   
}
