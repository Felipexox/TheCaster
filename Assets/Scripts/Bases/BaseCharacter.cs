using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : BasePhysics {
	protected double life;

	protected double mana;

	protected List<BaseAbility> abilities;

	protected virtual void CastAbility(BaseAbility ability){ }


}
