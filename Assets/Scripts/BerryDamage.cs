using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryDamage : MonoBehaviour
{
    // Start is called before the first frame update
   private bool _isStayTrigger;
   private PlayerController _playerController;
    void Start()
    {
        
       _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        
    }
    private void Update() {
        if(_isStayTrigger == true){
            OnDamage();
        }
        
    }
   private void OnTriggerEnter2D(Collider2D other) {
       _isStayTrigger=true;
   }
   private void OnTriggerExit2D(Collider2D other) {
        _isStayTrigger = false;
   }
    private void OnDamage() {
       if(Input.GetKeyDown("e")){
           _playerController.TakePlayerDamage(5f);
       }
   }
}
