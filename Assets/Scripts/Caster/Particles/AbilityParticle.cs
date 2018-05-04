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
}
