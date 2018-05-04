using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Magic", menuName = "MagicBook/New_Magic", order = 1)]
public class MagicScriptable : ScriptableObject {
    [SerializeField]
    private string name;
    [SerializeField]
    private Attribute attribute;
    [SerializeField]
    private string description;
    [SerializeField]
    private List<WordScriptable> words = new List<WordScriptable>();
    [SerializeField]
    private MagicParticle particle;
    [SerializeField]
    private AbilityScriptable ability;
    
    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public Attribute Attribute
    {
        get
        {
            return attribute;
        }

        set
        {
            attribute = value;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }

        set
        {
            description = value;
        }
    }

    public List<WordScriptable> Words
    {
        get
        {
            return words;
        }

        set
        {
            words = value;
        }
    }

    public MagicParticle Particle
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

    public AbilityScriptable Ability
    {
        get
        {
            return ability;
        }

        set
        {
            ability = value;
        }
    }
}
