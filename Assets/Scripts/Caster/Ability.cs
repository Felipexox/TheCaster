using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : BasePhysics {
    private float power;
    private float size;
    private BaseCharacter target = null;
    private Vector3 direction = Vector3.zero;
    private AbilityParticle particle;
    private TypeAbility typeAbility;
    private BaseCharacter ownerCharacter;
    private BaseCharacter sourceCharacter;
    private EffectScriptable effect;
    private void Update()
    {
        if(target != null)
        {
            direction = transform.position - target.transform.position;
        }
        if(direction != Vector3.zero)
        {
            Move(direction, power);
        }
        else
        {
            transform.RotateAround(ownerCharacter.transform.position, 20 * Time.deltaTime);
        }
    }

    public void AddEffect()
    {
        // create A new effect by scriptable object to add a some target
        if(target != null)
        {
            target.AddEffect(effect, sourceCharacter, this);
        }
    }

    public float Power
    {
        get
        {
            return power;
        }

        set
        {
            power = value;
        }
    }

    public float Size
    {
        get
        {
            return size;
        }

        set
        {
            size = value;
        }
    }

    public BaseCharacter Target
    {
        get
        {
            return target;
        }

        set
        {
            target = value;
        }
    }

    public Vector3 Direction
    {
        get
        {
            return direction;
        }

        set
        {
            direction = value;
        }
    }

    public AbilityParticle Particle
    {
        get
        {
            return particle;
        }

        set
        {
            particle = value;
        }
    }

    public TypeAbility TypeAbility
    {
        get
        {
            return typeAbility;
        }

        set
        {
            typeAbility = value;
        }
    }

    public BaseCharacter OwnerCharacter
    {
        get
        {
            return ownerCharacter;
        }

        set
        {
            ownerCharacter = value;
        }
    }

    public BaseCharacter SourceCharacter
    {
        get
        {
            return sourceCharacter;
        }

        set
        {
            sourceCharacter = value;
        }
    }

    public EffectScriptable Effect
    {
        get
        {
            return effect;
        }

        set
        {
            effect = value;
        }
    }
}
