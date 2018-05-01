using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
	public static InputManager instance;

	void Awake(){
		instance = this;
	}
	public Vector3 getDirection(){
		float x = Input.GetAxisRaw ("Horizontal");
		float z = Input.GetAxisRaw ("Vertical");
		Vector3 direction = new Vector3 (x, 0, z);
		return direction;
	}

}
