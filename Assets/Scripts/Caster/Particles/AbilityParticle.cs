using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityParticle : MonoBehaviour {
    [SerializeField]
    private Color32 baseColor;
    [SerializeField]
    private float speed;
    [SerializeField]
    private List<Color32> baseColors = new List<Color32>();
    [SerializeField]
    private ParticleSystem particleSystem;

    public Color32 BaseColor
    {
        get
        {
            return baseColor;
        }

        set
        {
            baseColor = value;
        }
    }

    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    public List<Color32> BaseColors
    {
        get
        {
            return baseColors;
        }

        set
        {
            baseColors = value;
        }
    }

    public ParticleSystem ParticleSystem
    {
        get
        {
            return particleSystem;
        }

        set
        {
            particleSystem = value;
        }
    }
}
