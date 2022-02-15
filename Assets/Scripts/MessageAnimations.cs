using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageAnimations : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator _animator;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void StartScence(){
        _animator.SetTrigger("StartScence");
    }
    public void EndScence(){
        _animator.SetTrigger("EndScence");
    }
}
