using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator _animator;
    public bool IsMoving{private get;set;}
    public bool IsFlying{private get;set;}

    private void Start() {
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        _animator.SetBool("isMoved", IsMoving);
        _animator.SetBool("IsFlying", IsFlying);
    }
    public void Jump(){
        _animator.SetTrigger("Jump");
    }
    public void FireArrow(){
        _animator.SetTrigger("FireArrow");
    }
    public void Combo(){
        _animator.SetTrigger("Combo_1");
    }
}

