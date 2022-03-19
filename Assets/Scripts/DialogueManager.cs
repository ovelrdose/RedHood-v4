using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> _sentences;
    
    public TextMeshProUGUI DialogueText;
    public GameObject DialoguePanel;
    public GameObject DialogueButton;

    
    
    void Start()
    {
        _sentences = new Queue<string>();
        
    }

    public void StartDialogue(Dialogue dialogue){
        
        DialoguePanel.SetActive(true);
        _sentences.Clear();
        foreach(string sentence in dialogue.sentences){
            _sentences.Enqueue(sentence);
        }
        if(_sentences.Count>1){
            DialogueButton.SetActive(true); 
        }
        DisplayNextSentence();
        
    }
    public void DisplayNextSentence(){
        if(_sentences.Count == 0){ // Написать скрипт здесь
            EndDialogues();
            return;
        }
        string sentence = _sentences.Dequeue();
        DialogueText.text = sentence;
    }
    public void EndDialogues(){
        
        DialoguePanel.SetActive(false);
    }
}
