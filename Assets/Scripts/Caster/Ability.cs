using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Ability {
    
    [SerializeField]
    private Sprite imageMagic;
    [SerializeField]
    private float power;
    [SerializeField]
    private float size;
    [SerializeField]
    private AbilityParticle particle;
    [SerializeField]
    private List<Effect.EffectControl> effects = new List<Effect.EffectControl>();
    [SerializeField]
    private TypeAbility typeAbility;



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

    public Sprite ImageMagic
    {
        get
        {
            return imageMagic;
        }

        set
        {
            imageMagic = value;
        }
    }

 
}
