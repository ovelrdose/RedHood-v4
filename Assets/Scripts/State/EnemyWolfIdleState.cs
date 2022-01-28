using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyWolfIdleState : EnemyWolfBaseState{
    private Rigidbody2D wolfRB; 
    private WolfAnimations _animations;
    private GameObject Player;
    public Vector3 _startEnemyPos;
    private bool m_FacingRight = true; 
    
    public override void EnterState(EnemyWolfStateManager enemy){
        Debug.Log("Wolf IDL");
        wolfRB = enemy.GetComponent<Rigidbody2D>();
        _animations = enemy.GetComponent<WolfAnimations>();
        Player = GameObject.Find("Player");
        _startEnemyPos = enemy.transform.position;
        if(Player.transform.position.x<wolfRB.transform.position.x){
                    wolfRB.transform.Rotate(0f, 180f, 0f);
    
                }
        if(Player.transform.position.x>wolfRB.transform.position.x){
            wolfRB.transform.Rotate(0f, 180f, 0f);
        }
        
       
    }
    public override void UpdateState(EnemyWolfStateManager enemy){

        
        if(Vector2.Distance(Player.transform.position,wolfRB.transform.position)<4 ){
            enemy.SwitchState(enemy.wolfMoveState);
        }
    }
    public override void onCollisionEnter(EnemyWolfStateManager enemy){

    }
}


