using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scence : MonoBehaviour
{
    public Animator Anim;
    
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other) {
        Anim.SetTrigger("Fade_Out");
        
    }
}
