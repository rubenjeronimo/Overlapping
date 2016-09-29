using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class nuevaCamara : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Application.LoadLevel("nuevaCamara");
		Debug.Log ("nueva camara");
	}
}
