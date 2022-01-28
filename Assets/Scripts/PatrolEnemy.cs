using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    public Transform CurrentPosition;
    private Rigidbody2D wolfRB; 
    private WolfAnimations _animations;
    private GameObject Player;
    public Vector3 _startEnemyPos;
    public Vector2 player;
    public Vector2 enemy;
    public bool m_FacingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        wolfRB = GetComponent<Rigidbody2D>();
        _animations = GetComponent<WolfAnimations>();
        Player = GameObject.Find("Player");
        _startEnemyPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Patrol(){
        Debug.Log(Vector2.Dot(player,enemy));
        if(transform.position!=_startEnemyPos ){
            _animations.IsMoving = true;

            transform.position = Vector2.MoveTowards(transform.position, _startEnemyPos, 1 * Time.deltaTime);
            if(Player.transform.position.x<wolfRB.transform.position.x&&m_FacingRight==true){
                    wolfRB.transform.Rotate(0f, 180f, 0f);
                    m_FacingRight = false;
                    
                }
             if(Player.transform.position.x>wolfRB.transform.position.x&&m_FacingRight==true){
                    wolfRB.transform.Rotate(0f, 180f, 0f);
                    m_FacingRight = false;
                    
                }
            
            
            
            
        }
        else{
           
            m_FacingRight = true;
        }
        
    }
    
}
