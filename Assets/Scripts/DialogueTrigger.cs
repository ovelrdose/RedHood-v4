using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private GameObject _player;
    public DialogueManager DialogueManager;
    
    
    void Start()
    {
        _player = GameObject.Find("Player");
       
        
    }

   private void OnTriggerEnter2D(Collider2D other) {
       
       if(other.name =="Player"){
           
           FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
       }
   }
   private void OnTriggerExit2D(Collider2D other) {
        DialogueManager.EndDialogues();  
         if(other.name =="Player"){
        Destroy(gameObject);
        }
   }
    
   
  
}
