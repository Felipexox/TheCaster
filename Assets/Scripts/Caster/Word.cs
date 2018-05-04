using System.Collections;
using UnityEngine;
using System.Collections.Generic;
[System.Serializable]
public class Word{
    [SerializeField]
    protected bool complete;
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
    public bool Complete
    {
        get
        {
            return complete;
        }

        set
        {
            complete = value;
        }
    }
    public Word(WordScriptable wordScriptable)
    {
        this.typeWord = wordScriptable.TypeWord;
        this.times = wordScriptable.Times;
        this.key = wordScriptable.Key;
        this.waitTime = wordScriptable.WaitTime;
    }
    public virtual IEnumerator ReadingWord()
    {
    
        yield return ChooseWord(typeWord);
        complete = true;
    
    }
    private IEnumerator ChooseWord(TypeWord type)
    {
        switch (type)
        {
            case TypeWord.WORD_PRESS_BUTTON:
                yield return Word_Press_Button();
                break;
            case TypeWord.WORD_WAIT_X_TIMES:
                yield return Word_Wait_X_Time();
                break;
        }
        yield return 0;
    }
    public IEnumerator Word_Wait_X_Time()
    {
        yield return new WaitForSeconds(WaitTime);

        yield return new WaitUntil(() => Input.GetKeyDown(Key));
    }
    public IEnumerator Word_Press_Button()
    {
        for(int i = 0; i < Times; i++)
        {
            yield return new WaitUntil(() => Input.GetKeyDown(Key));
        }
    }

   
}
