using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IJunior.TypedScenes;

public class LevelScenceManager : MonoBehaviour
{
    private RunFoxAway _fox;
    private void Start() {
        _fox = GameObject.Find("Fox").GetComponent<RunFoxAway>();
    }
   private void OnTriggerEnter2D(Collider2D other) {
       if(other.tag=="Player"){
           _fox.RunFox = true;
       }
        
   }
}
