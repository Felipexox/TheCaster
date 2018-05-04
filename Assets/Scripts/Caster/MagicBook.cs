using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBook : MonoBehaviour {
    [SerializeField]
    private BookScriptable book;
    [SerializeField]
    private BaseCharacter ownerCharacter;
    [SerializeField]
    private List<Magic> magics = new List<Magic>();

    public BaseCharacter OwnerCharacter
    {
        get
        {
            return ownerCharacter;
        }

        set
        {
            ownerCharacter = value;
        }
    }

    public List<Magic> Magics
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

    public void Awake()
    {
        int size = book.Magics.Count;
        for(int i = 0; i < size; i++)
        {
            Magic magic = new Magic(book.Magics[i], this);
            magics.Add(magic);
        }
    }

    public void ChooseMagic(int index)
    {
        StartCoroutine(magics[index].ReadingMagic());
    }

}
