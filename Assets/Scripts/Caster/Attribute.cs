using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Attribute {
    [SerializeField]
    private TypeAttribute typeAttribute;

    public TypeAttribute TypeAttribute
    {
        get
        {
            return typeAttribute;
        }

        set
        {
            typeAttribute = value;
        }
    }
}
