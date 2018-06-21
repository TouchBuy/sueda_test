using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class sample_change_scene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Console.WriteLine("Hello World!");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)==true){
			SceneManager.LoadScene("SampleScene");
		}
	}
}
