using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class BasePhysics : MonoBehaviour {
	protected Rigidbody rigid;
	protected virtual void Awake(){
		rigid = GetComponent<Rigidbody> ();
	}
	protected virtual void Move (Vector3 direction, float velocity){ 
		Vector3 currentVelocity = rigid.velocity;
		Vector3 directionVelocity = direction.normalized;

		currentVelocity += directionVelocity;
		currentVelocity = Vector3.ClampMagnitude (currentVelocity, velocity);
		rigid.velocity = currentVelocity;
	}

	protected virtual void TakeHit(BaseAbility ability){ }


}
