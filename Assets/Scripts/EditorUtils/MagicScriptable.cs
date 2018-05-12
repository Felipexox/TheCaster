using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Magic", menuName = "MagicBook/New_Magic", order = 1)]
public class MagicScriptable : ScriptableObject {
    [Header("Magic Attributes")]
    [SerializeField]
    private string name;
    [SerializeField]
    private Attribute attribute;
    [SerializeField]
    private string description;
    [Header("Words To Cast Magic")]
    [SerializeField]
    private List<Word> words = new List<Word>();
    [Header("Particle Used")]
    [SerializeField]
    private MagicParticle particle;
    [Header("Ability Area")]
    [SerializeField]
    private Ability ability;
    
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

    public List<Word> Words
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

    public Ability Ability
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
