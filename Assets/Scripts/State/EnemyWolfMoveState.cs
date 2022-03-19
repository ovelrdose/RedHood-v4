using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWolfMoveState : EnemyWolfBaseState{
    private Rigidbody2D _wolfRB; 
    private WolfAnimations _animations;
    private GameObject _player;
    private bool _facingRight = true; 
    private Enemy _enemyHealth;
    private float _enemySpeed;
    
    public override void EnterState(EnemyWolfStateManager enemy){
        Debug.Log("Wolf walkState");
        _wolfRB = enemy.GetComponent<Rigidbody2D>();
        _animations = enemy.GetComponent<WolfAnimations>();
        _player = GameObject.Find("Player"); 
        _enemyHealth = enemy.GetComponent<Enemy>();
        _enemySpeed = enemy.GetComponent<Enemy>().Speed;
    }
    public override void UpdateState(EnemyWolfStateManager enemy){
       
            _animations.IsMoving=true; 
            enemy.GetComponent<CheckVectorMove>().ChangeBool(); 
            if (_player.transform.position.x < _wolfRB.transform.position.x ){
                _wolfRB.velocity = new Vector2(-_enemySpeed, _wolfRB.velocity.y);

                if(!_facingRight){
                    _wolfRB.transform.Rotate(0f, 180f, 0f);
                    _facingRight = !_facingRight;
                }
            }
            else{
                _wolfRB.velocity = new Vector2(_enemySpeed, _wolfRB.velocity.y);
                if(_facingRight){
                    _wolfRB.transform.Rotate(0f, 180f, 0f);
                    _facingRight = !_facingRight;
                }  
            }
        
            if(Vector2.Distance(_player.transform.position,_wolfRB.transform.position)>7){
            _animations.IsMoving = true;
            enemy.GetComponent<Enemy>().IsAgred=false;
            enemy.SwitchState(enemy.wolfAwayState);
                
            }
            if(_enemyHealth.Health<=0){
                enemy.SwitchState(enemy.wolfDieState);
            }
            if(enemy.GetComponent<CheckVectorMove>().WolfFireBack == true){
                
                enemy.SwitchState(enemy.wolfAwayState);
            }
        
     
    }
    public override void onCollisionEnter(EnemyWolfStateManager enemy){

    }
}
