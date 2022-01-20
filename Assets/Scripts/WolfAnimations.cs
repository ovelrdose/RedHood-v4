using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfAnimations : MonoBehaviour
{
    private Animator _animator;
    public bool IsMoving{private get;set;}
     private void Start() {
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        _animator.SetBool("isMoved", IsMoving);
        
    }
     public void isAttack(){
        _animator.SetTrigger("isAttack");
    }
}
