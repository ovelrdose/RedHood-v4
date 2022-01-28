using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWolfAwayState : EnemyWolfBaseState
{   
    private Rigidbody2D wolfRB; 
    private WolfAnimations _animations;
    private GameObject Player;
    private Vector3 _startEnemyPos;
    private bool m_FacingRight = true; 
    public override void EnterState(EnemyWolfStateManager enemy){
        Debug.Log("Wolf Away State");
        wolfRB = enemy.GetComponent<Rigidbody2D>();
        _animations = enemy.GetComponent<WolfAnimations>();
        Player = GameObject.Find("Player");
        
        
    }

    public override void UpdateState(EnemyWolfStateManager enemy){
       
        enemy.GetComponent<PatrolEnemy>().Patrol();
        
        
        if(enemy.GetComponent<PatrolEnemy>()._startEnemyPos == enemy.transform.position){
            _animations.IsMoving = false;
            enemy.GetComponent<PatrolEnemy>().m_FacingRight = true;
            enemy.SwitchState(enemy.wolfIdleState);
        }
    }

    public override void onCollisionEnter(EnemyWolfStateManager enemy){

    }
}
