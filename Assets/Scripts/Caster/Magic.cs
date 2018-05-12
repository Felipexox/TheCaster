using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Magic {
    [SerializeField]
    private string name;
    [SerializeField]
    private Attribute attribute;
    [SerializeField]
    private string description;
    [SerializeField]
    private List<Word> words = new List<Word>();
    [SerializeField]
    private MagicParticle particle;
    [SerializeField]
    private Ability ability;
    [SerializeField]
    private MagicBook magicBook;
    public IEnumerator ReadingMagic()
    {
        float complete = 0;

        for (int i = 0; i < words.Count; i++)
        {
            yield return words[i].ReadingWord();
            complete += words[i].Complete ? 1 : 0;
            words[i].Complete = false;
        }
        float sucessful = (complete / words.Count) * 100;
        CastMagic();

    }

    public void CastMagic()
    {
    
        //TO DO Create AbilityComponent
        GameObject newAbility = new GameObject(this.name + " ( Ability )");
        newAbility.transform.parent = magicBook.OwnerCharacter.transform;
        AbilityComponent abilityComponent = newAbility.AddComponent<AbilityComponent>();
        newAbility.SetActive(false);
        // add AbilityComponent Component to a new Magic Object
        abilityComponent.Power = ability.Power;
        abilityComponent.Size = ability.Size;
        abilityComponent.OwnerCharacter = magicBook.OwnerCharacter;
        abilityComponent.SourceCharacter = magicBook.OwnerCharacter;
        abilityComponent.TypeAbility = ability.TypeAbility;
        abilityComponent.Effects = ability.Effects;
        abilityComponent.Particle = ability.Particle;
        abilityComponent.Rigid.useGravity = false;

        // add particle AbilityComponent to a new Magic Object
 
     
        ParticleSystem particleSystem = UnityUtils.CopyComponent<ParticleSystem>(ability.Particle.ParticleSystem, newAbility);
        ParticleSystemRenderer particleSystemRenderer = newAbility.GetComponent<ParticleSystemRenderer>();
        particleSystemRenderer.material = new Material(Shader.Find("Particles/Additive"));
        particleSystemRenderer.material.mainTexture = ability.ImageMagic.texture;
        newAbility.SetActive(true);
    }

    public Magic(MagicScriptable magicObject, MagicBook ownerBook)
    {
        this.name = magicObject.Name;
        this.description = magicObject.Description;
        this.attribute = magicObject.Attribute;
        this.ability = magicObject.Ability;
        this.particle = magicObject.Particle;
        this.magicBook = ownerBook;

        this.words = new List<Word>(magicObject.Words);
    }

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

    public MagicBook MagicBook
    {
        get
        {
            return magicBook;
        }

        set
        {
            magicBook = value;
        }
    }
}
