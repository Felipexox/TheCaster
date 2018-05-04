using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Book", menuName = "MagicBook/New_Book", order = 0)]
public class BookScriptable : ScriptableObject {
    [SerializeField]
    private List<MagicScriptable> magics = new List<MagicScriptable>();

    public List<MagicScriptable> Magics
    {
        get
        {
            return magics;
        }

        set
        {
            magics = value;
        }
    }
}
