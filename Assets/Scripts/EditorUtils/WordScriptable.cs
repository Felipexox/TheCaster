using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Word", menuName = "MagicBook/New_Word", order = 4)]
public class WordScriptable : ScriptableObject {
    [SerializeField]
    private TypeWord typeWord;
    [SerializeField]
    private float waitTime;
    [SerializeField]
    private float times;
    [SerializeField]
    private KeyCode key;
    public TypeWord TypeWord
    {
        get
        {
            return typeWord;
        }

        set
        {
            typeWord = value;
        }
    }

    public float WaitTime
    {
        get
        {
            return waitTime;
        }

        set
        {
            waitTime = value;
        }
    }

    public float Times
    {
        get
        {
            return times;
        }

        set
        {
            times = value;
        }
    }

    public KeyCode Key
    {
        get
        {
            return key;
        }

        set
        {
            key = value;
        }
    }
}
