using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWolfMoveState : EnemyWolfBaseState{
    private Rigidbody2D wolfRB; 
    private WolfAnimations _animations;
    private GameObject Player;
    private bool m_FacingRight = true; 
    public override void EnterState(EnemyWolfStateManager enemy){
        Debug.Log("Wolf walkState");
        wolfRB = enemy.GetComponent<Rigidbody2D>();
        _animations = enemy.GetComponent<WolfAnimations>();
        Player = GameObject.Find("Player"); 
    }
    public override void UpdateState(EnemyWolfStateManager enemy){
        if(Vector2.Distance(Player.transform.position,wolfRB.transform.position)<4){
            _animations.IsMoving=true;  
            if (Player.transform.position.x < wolfRB.transform.position.x ){
                wolfRB.velocity = new Vector2(-1, wolfRB.velocity.y);
                if(!m_FacingRight){
                    wolfRB.transform.Rotate(0f, 180f, 0f);
                    m_FacingRight = !m_FacingRight;
                }
            }
            else{
                wolfRB.velocity = new Vector2(1, wolfRB.velocity.y);
                if(m_FacingRight){
                    wolfRB.transform.Rotate(0f, 180f, 0f);
                    m_FacingRight = !m_FacingRight;
                }  
            }
        }
        if(Vector2.Distance(Player.transform.position,wolfRB.transform.position)>4){
            //wolfRB.velocity = new Vector2(0, wolfRB.velocity.y);// тут должен быть переход в новое состояние 
           // _animations.IsMoving=false;
           _animations.IsMoving = true;
           enemy.SwitchState(enemy.wolfAwayState);
            
        }
        if(Vector2.Distance(Player.transform.position,wolfRB.transform.position)>4 ){
            wolfRB.velocity = new Vector2(0, wolfRB.velocity.y);// тут должен быть переход в новое состояние 
            _animations.IsMoving=false;
        }
      
    }
    public override void onCollisionEnter(EnemyWolfStateManager enemy){

    }
}
