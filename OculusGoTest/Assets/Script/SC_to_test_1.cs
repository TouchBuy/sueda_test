using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SC_to_test_1 : MonoBehaviour{
    // Use this for initialization
    void Start(){

    }
    // Update is called once per frame
    void Update(){
        if(Input.GetMouseButtonDown(0)==true){
            SceneManager.LoadScene("test_1");
        }
    }
}
