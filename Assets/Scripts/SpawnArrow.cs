

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArrow : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform shotPoint;
    private PlayerAnimations _animations;
    public bool goArrow;
    private PlayerController _playerController;
    
   
   private void Start() {
        _animations = GetComponent<PlayerAnimations>();    
       _playerController =  GetComponent<PlayerController>();
   }

    void Update()
    {
        
        if(Input.GetMouseButtonDown(1)&& goArrow == false &&_playerController._isGrounded == true){

            Shoot();
            _animations.FireArrow();
            StartCoroutine(ReloadFire());
        }
      
    }
 
    IEnumerator ReloadFire(){
        yield return new WaitForSeconds(0.35f);
        goArrow = false;
    }

    void Shoot(){
        Instantiate(arrowPrefab,shotPoint.position,transform.rotation);
        goArrow = true;  
    }
}






