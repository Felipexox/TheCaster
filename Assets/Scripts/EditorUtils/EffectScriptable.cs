using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Effect", menuName = "MagicBook/New_Effect", order = 3)]
public class EffectScriptable : ScriptableObject {
    [SerializeField]
    private List<Effect.EffectControl> effectControl = new List<Effect.EffectControl>();

    public List<Effect.EffectControl> EffectControl
    {
        get
        {
            return effectControl;
        }

        set
        {
            effectControl = value;
        }
    }
}
