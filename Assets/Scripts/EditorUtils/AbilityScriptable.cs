using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Ability", menuName = "MagicBook/New_Ability", order = 2)]
public class AbilityScriptable : ScriptableObject {
    [SerializeField]
    private Sprite imageMagic;
    [SerializeField]
    private float power;
    [SerializeField]
    private float size;
    [SerializeField]
    private AbilityParticle particle;
    [SerializeField]
    private EffectScriptable effect;
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
