using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public int NumberOfScence;
    
     public void ScenceLoad(){
        SceneManager.LoadScene(NumberOfScence);
    }
}
