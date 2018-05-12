using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : BasePhysics {
	protected double life;

	protected double mana;

    protected List<AbilityComponent> abilitiesCasted = new List<AbilityComponent>();

    protected List<Effect> effects = new List<Effect>();

    [SerializeField]
    protected MagicBook magicBook;

    public void AddEffect(List<Effect.EffectControl> effects, BaseCharacter sourceEffect, AbilityComponent sourceAbility)
    {
        // add the new component effect how run the effects and then are destroied
        Effect effectComponent = gameObject.AddComponent<Effect>();
        effectComponent.Effects = new List<Effect.EffectControl>(effects);
        effectComponent.SourceAbility = sourceAbility;
        effectComponent.EffectTarget = this;

        effectComponent.RunEffects();
    }
    public virtual void TakeDamage(float damage)
    {
        life -= damage;
    }


}
