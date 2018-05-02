using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBook : MonoBehaviour {
    private List<Magic> magics;

    public void ChooseMagic(Magic magic)
    {
        StartCoroutine(magic.ReadingMagic());
    }

}
