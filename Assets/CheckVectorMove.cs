using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVectorMove : MonoBehaviour
{
   public Transform CurrentPosition;
    private Rigidbody2D wolfRB; 
    private WolfAnimations _animations;
    private GameObject Player;
    public Vector3 _startEnemyPos;
    public bool m_FacingRight = true;
    public bool IsLeft;
    // Start is called before the first frame update
    void Start()
    {
        wolfRB = GetComponent<Rigidbody2D>();
        _animations = GetComponent<WolfAnimations>();
        Player = GameObject.Find("Player");
        _startEnemyPos = transform.position;
    }

    public void CheckVector(){
         if (Player.transform.position.x < wolfRB.transform.position.x ){
                IsLeft=true;
            }
         if (Player.transform.position.x > wolfRB.transform.position.x ){
                IsLeft=false;
            }
        
    }
}
