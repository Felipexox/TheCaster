using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour {
    [System.Serializable]
    public class EffectControl
    {
        [SerializeField]
        private TypeEffect effect;
        [SerializeField]
        private float value;
        [SerializeField]
        private float timeDuration;
        [SerializeField]
        private int hits;
        [SerializeField]
        private float delay;

        public TypeEffect Effect
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

        public float Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public float TimeDuration
        {
            get
            {
                return timeDuration;
            }

            set
            {
                timeDuration = value;
            }
        }

        public int Hits
        {
            get
            {
                return hits;
            }

            set
            {
                hits = value;
            }
        }

        public float Delay
        {
            get
            {
                return delay;
            }

            set
            {
                delay = value;
            }
        }
    }

    private List<EffectControl> effects = new List<EffectControl>();
    private Ability sourceAbility;
    private BaseCharacter effectTarget;
    private int controller = 0;
    public IEnumerator RunEffects()
    {
        for (int i = 0; i < effects.Count; i++)
        {

            EffectEntity(effects[i]);
            controller++;
        }
        yield return new WaitWhile(() =>  controller != 0);
        Destroy(this);
    }
    public void EffectEntity(EffectControl effect)
    {
        switch (effect.Effect)
        {
            case TypeEffect.DEALDAMAGE:
                StartCoroutine(DealDamage(effect));
                break;
            case TypeEffect.PUSH:
                StartCoroutine(Push(effect));
                break;
        }
    }
    public List<EffectControl> Effects
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

    public Ability SourceAbility
    {
        get
        {
            return sourceAbility;
        }

        set
        {
            sourceAbility = value;
        }
    }

    public BaseCharacter EffectTarget
    {
        get
        {
            return effectTarget;
        }

        set
        {
            effectTarget = value;
        }
    }

    // effects 

    IEnumerator DealDamage(EffectControl effect)
    {
        float hits = 0;
        while(hits < effect.Hits)
        {
            EffectTarget.TakeDamage(effect.Value);

            hits++;
            yield return new WaitForSeconds(effect.Delay);
        }
        controller--;
    }

    IEnumerator Push(EffectControl effect)
    {
        float hits = 0;
        while (hits < effect.Hits)
        {
            Vector3 direction = sourceAbility.SourceCharacter.transform.position - EffectTarget.transform.position;
            EffectTarget.AddForce( direction ,effect.Value);

            hits++;
            yield return new WaitForSeconds(effect.Delay);
        }
        controller--;
    }
}
