using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWolfAwayState : EnemyWolfBaseState
{   
    private Rigidbody2D _wolfRB; 
    private WolfAnimations _animations;
    private GameObject _player;
    private Vector3 _startEnemyPos;
    
    
    public override void EnterState(EnemyWolfStateManager enemy){
        Debug.Log("Wolf Away State");
        _wolfRB = enemy.GetComponent<Rigidbody2D>();
        _animations = enemy.GetComponent<WolfAnimations>();
        _player = GameObject.Find("Player");
        
        
        
    }

    public override void UpdateState(EnemyWolfStateManager enemy){
       
        enemy.GetComponent<SwitchStateEnemy>().Patrol();
        
        
        if(enemy.GetComponent<SwitchStateEnemy>()._startEnemyPos == enemy.transform.position){
            _animations.IsMoving = false;
            enemy.GetComponent<SwitchStateEnemy>().m_FacingRight = true;
            enemy.SwitchState(enemy.wolfIdleState);
        }
    }

    public override void onCollisionEnter(EnemyWolfStateManager enemy){

    }
}
