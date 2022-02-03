using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyWolfIdleState : EnemyWolfBaseState{
    private Rigidbody2D _wolfRB; 
    private WolfAnimations _animations;
    private GameObject _player;
    public Vector3 _startEnemyPos;
    
    
    public override void EnterState(EnemyWolfStateManager enemy){
        Debug.Log("Wolf IDL");
        _wolfRB = enemy.GetComponent<Rigidbody2D>();
        _animations = enemy.GetComponent<WolfAnimations>();
        _player = GameObject.Find("Player");
        _startEnemyPos = enemy.transform.position;
        if(_player.transform.position.x<_wolfRB.transform.position.x){
                    _wolfRB.transform.Rotate(0f, 180f, 0f);
    
                }
        if(_player.transform.position.x>_wolfRB.transform.position.x){
            _wolfRB.transform.Rotate(0f, 180f, 0f);
        }
        
       
    }
    public override void UpdateState(EnemyWolfStateManager enemy){

        
        if(Vector2.Distance(_player.transform.position,_wolfRB.transform.position)<4 ){
            enemy.SwitchState(enemy.wolfMoveState);
        }
    }
    public override void onCollisionEnter(EnemyWolfStateManager enemy){

    }
}


