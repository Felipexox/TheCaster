using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour {
    private string name;
    private Attribute attribute;
    private string description;
    private List<Word> words = new List<Word>();
    private Action action;
    private MagicParticle particle;

    public IEnumerator ReadingMagic() {
        for(int i = 0; i < words.Count; i++)
        {
            yield return words[i].ReadingWord();
        }
    }

	
}
