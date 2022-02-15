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
       if(other.name=="Player"){
           FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

       }
   }
   private void Update() {
       CountDistance();
   }
   void CountDistance(){
    if(Vector2.Distance(transform.position,_player.transform.position)>3){
        DialogueManager.EndDialogues();
    }

   }
  
}
