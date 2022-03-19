using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVectorMove : MonoBehaviour
{
    public Transform FirePosition;
    private Rigidbody2D _wolfRB; 
    private WolfAnimations _animations;
    private GameObject _player;
    public bool WolfFireBack;

    
    // Start is called before the first frame update
    void Start()
    {
        _animations = GetComponent<WolfAnimations>();
        _player = GameObject.Find("Player");
      
    }
    public void ChangeBool(){
        if(transform.position.x > FirePosition.transform.position.x){
            WolfFireBack = false;
        }else{
            WolfFireBack = true;
        }
       
    }

   
}
