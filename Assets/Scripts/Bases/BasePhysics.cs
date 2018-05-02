using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class BasePhysics : MonoBehaviour {
	protected Rigidbody rigid;
	protected Vector3 acceleration;
	protected Vector3 velocity;
	protected virtual void Awake(){
		rigid = GetComponent<Rigidbody> ();
	}
	protected virtual void Move (Vector3 p_Direction, float p_Velocity){ 
		Vector3 acceleration = ResultForce (p_Direction.normalized, p_Velocity);
		Vector3 resultVelocity = VelocityController (acceleration);
		rigid.velocity = resultVelocity;
	}
	protected virtual Vector3 ResultForce(Vector3 p_Direction, float p_Force){
		acceleration += (p_Direction * p_Force) * Time.deltaTime;
		//friction
		acceleration -= acceleration * Time.deltaTime * 10;
		return acceleration;
	}
	protected virtual Vector3 VelocityController(Vector3 p_Acceleration){
		velocity += p_Acceleration;
		//friction
		velocity -= velocity * Time.deltaTime * 5;
		return velocity;
	}
	public virtual void AddForce(Vector3 p_Direction, float p_Force){
		ResultForce (p_Direction, p_Force);
	}
	protected virtual void TakeHit(BaseAbility ability){ }


}
