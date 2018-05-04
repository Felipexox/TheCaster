using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseCharacter {
	private bool isCasting;
    protected override void Awake()
    {
        base.Awake();
        magicBook.OwnerCharacter = this;
    }
    void Update(){
		Move (InputManager.instance.getDirection (), 5);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            magicBook.ChooseMagic(0);
        }
	}

}
