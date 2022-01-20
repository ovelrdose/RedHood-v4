using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float _health = 100;
    public bool _isAgred = false;
    private WolfAnimations _animations;
    void Start()
    {
        _animations = GetComponent<WolfAnimations>();
        
    }
    
    public void TakeEnemyDamage(float damage){
        IsAgred();
        _health -=damage;
        if(_health<=0){
            Die();
        }
    }
    private void Die(){
        Destroy(gameObject);
        Debug.Log("Enemy Die");
    }
    private void IsAgred(){
        _isAgred =true;  
    }
    
}
