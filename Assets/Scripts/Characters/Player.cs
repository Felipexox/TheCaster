using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseCharacter {
	private bool isCasting;

	void Update(){
		Move (InputManager.instance.getDirection (), 5);

	}

}
