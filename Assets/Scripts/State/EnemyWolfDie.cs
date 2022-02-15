using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWolfDie : EnemyWolfBaseState
{
    private Rigidbody2D _wolfRB; 
    private WolfAnimations _animations;
    private GameObject _player;
    private Vector3 _startEnemyPos;
    
    public override void EnterState(EnemyWolfStateManager enemy){
        Debug.Log("Wolf Die ");
        _wolfRB = enemy.GetComponent<Rigidbody2D>();
        _animations = enemy.GetComponent<WolfAnimations>();
        _player = GameObject.Find("Player");
        
        
    }

    public override void UpdateState(EnemyWolfStateManager enemy){
       enemy.GetComponent<SwitchStateEnemy>().DieWolf();
       
        
    }

    public override void onCollisionEnter(EnemyWolfStateManager enemy){

    }
   
}
