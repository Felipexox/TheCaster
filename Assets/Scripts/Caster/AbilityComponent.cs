using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityComponent : BasePhysics {
    [SerializeField]
    private float power;
    [SerializeField]
    private float size;
    [SerializeField]
    private BaseCharacter target = null;
    [SerializeField]
    private Vector3 direction = Vector3.zero;
    [SerializeField]
    private AbilityParticle particle;
    [SerializeField]
    private TypeAbility typeAbility;
    [SerializeField]
    private BaseCharacter ownerCharacter;
    [SerializeField]
    private BaseCharacter sourceCharacter;
    [SerializeField]
    private Magic sourceMagic;
    [SerializeField]
    private List<Effect.EffectControl> effects = new List<Effect.EffectControl>();
    protected override void Awake()
    {
        base.Awake();
    
    }
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
            transform.RotateAround(ownerCharacter.transform.position, Vector3.up, 80 * Time.deltaTime);
            if(Vector3.Distance(transform.position, ownerCharacter.transform.position) > 2)
            {
                transform.position = Vector3.Lerp(transform.position,  -(transform.position - ownerCharacter.transform.position) , Time.deltaTime * 0.5f);
            }
        }
    }

    public void AddEffect()
    {
        // create A new effect by scriptable object to add a some target
        if(target != null)
        {
            target.AddEffect(effects, sourceCharacter, this);
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

    public List<Effect.EffectControl> Effects
    {
        get
        {
            return effects;
        }

        set
        {
            effects = value;
        }
    }

    public Magic SourceMagic
    {
        get
        {
            return sourceMagic;
        }

        set
        {
            sourceMagic = value;
        }
    }
}
