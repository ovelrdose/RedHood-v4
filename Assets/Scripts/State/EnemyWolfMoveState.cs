using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWolfMoveState : EnemyWolfBaseState{
    private Rigidbody2D _wolfRB; 
    private WolfAnimations _animations;
    private GameObject _player;
    private bool _facingRight = true; 
    
    public override void EnterState(EnemyWolfStateManager enemy){
        Debug.Log("Wolf walkState");
        _wolfRB = enemy.GetComponent<Rigidbody2D>();
        _animations = enemy.GetComponent<WolfAnimations>();
        _player = GameObject.Find("Player"); 
    }
    public override void UpdateState(EnemyWolfStateManager enemy){
        if(Vector2.Distance(_player.transform.position,_wolfRB.transform.position)<7){
            _animations.IsMoving=true; 
            enemy.GetComponent<CheckVectorMove>().CheckVector(); 
            if (_player.transform.position.x < _wolfRB.transform.position.x ){
                _wolfRB.velocity = new Vector2(-1, _wolfRB.velocity.y);

                if(!_facingRight){
                    _wolfRB.transform.Rotate(0f, 180f, 0f);
                    _facingRight = !_facingRight;
                }
            }
            else{
                _wolfRB.velocity = new Vector2(1, _wolfRB.velocity.y);
                if(_facingRight){
                    _wolfRB.transform.Rotate(0f, 180f, 0f);
                    _facingRight = !_facingRight;
                }  
            }
        }
        if(Vector2.Distance(_player.transform.position,_wolfRB.transform.position)>7){
           _animations.IsMoving = true;
           enemy.SwitchState(enemy.wolfAwayState);
            
        }
     
    }
    public override void onCollisionEnter(EnemyWolfStateManager enemy){

    }
}
