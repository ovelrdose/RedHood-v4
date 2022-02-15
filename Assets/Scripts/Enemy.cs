using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health = 100;
    public float Speed =1f;
    public float SpeedAway = 2.5f;
    public bool IsAgred = false;
   
    private WolfAnimations _animations;
    void Start()
    {
        _animations = GetComponent<WolfAnimations>();
        
    }
    
    public void TakeEnemyDamage(float damage){
        IsAgred = true;

        Health -=damage;
    //     if(Health<=0){
    //         Die();
    //     }
    }
    // private void Die(){
    //     Destroy(gameObject);
    //     Debug.Log("Enemy Die");
    // }
   
    
}
