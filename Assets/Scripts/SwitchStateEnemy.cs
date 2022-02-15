using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStateEnemy : MonoBehaviour
{
    public Transform CurrentPosition;
    private Rigidbody2D _wolfRB; 
    private WolfAnimations _animations;
    private GameObject _player;
    public Vector3 _startEnemyPos;
    private float _enemySpeedAway;
   
    public bool m_FacingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        _wolfRB = GetComponent<Rigidbody2D>();
        _animations = GetComponent<WolfAnimations>();
        _player = GameObject.Find("Player");
        _startEnemyPos = transform.position;
        _enemySpeedAway = GetComponent<Enemy>().SpeedAway;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Patrol(){
        if(transform.position!=_startEnemyPos ){
            _animations.IsMoving = true;

            transform.position = Vector2.MoveTowards(transform.position, _startEnemyPos, _enemySpeedAway  * Time.deltaTime);
            if(_player.transform.position.x<_wolfRB.transform.position.x&&m_FacingRight==true){
                    _wolfRB.transform.Rotate(0f, 180f, 0f);
                    m_FacingRight = false;
                    
                }
             if(_player.transform.position.x>_wolfRB.transform.position.x&&m_FacingRight==true){
                    _wolfRB.transform.Rotate(0f, 180f, 0f);
                    m_FacingRight = false;
                    
                }
            
            
            
            
        }
        else{
           
            m_FacingRight = true;
        }
        
    }

    public void DieWolf(){
        if(transform.position!=_startEnemyPos ){
            _animations.IsMoving = true;

            transform.position = Vector2.MoveTowards(transform.position, _startEnemyPos, _enemySpeedAway * Time.deltaTime);
            if(_player.transform.position.x<_wolfRB.transform.position.x&&m_FacingRight==true){
                    _wolfRB.transform.Rotate(0f, 180f, 0f);
                    m_FacingRight = false;
                    
                }
             if(_player.transform.position.x>_wolfRB.transform.position.x&&m_FacingRight==true){
                    _wolfRB.transform.Rotate(0f, 180f, 0f);
                    m_FacingRight = false;
                    
                }
            
            
            
            
        }
        else{
           
            m_FacingRight = true;
        }
        if(_startEnemyPos ==transform.position){
           Destroy(gameObject);
        }
        
    }
    
}
