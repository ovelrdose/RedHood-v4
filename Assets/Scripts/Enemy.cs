using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Health = 100;
   
    private WolfAnimations _animations;
    void Start()
    {
        _animations = GetComponent<WolfAnimations>();
        
    }
    
    public void TakeEnemyDamage(float damage){
        
        Health -=damage;
        if(Health<=0){
            Die();
        }
    }
    private void Die(){
        Destroy(gameObject);
        Debug.Log("Enemy Die");
    }
   
    
}
