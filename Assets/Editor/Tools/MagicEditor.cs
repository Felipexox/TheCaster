
using UnityEngine;
using UnityEditor;
public class MagicEditor : EditorWindow {
    public static MagicScriptable magicScriptable;
    private float sizeX = 500, sizeY = 600;
    int selected = 0;
    public static void CreateWindow()
    {
        GetWindow<MagicEditor>("Magic Editor");
    }
    private void OnGUI()
    {
        minSize = new Vector2(sizeX, sizeY);
        if(Selection.objects.Length > 0 && magicScriptable == null)
            magicScriptable = Selection.objects[0] as MagicScriptable;
        if (magicScriptable != null)
        {
            DrawMagicAttributes();
            DrawTabs();
        }
    }

    private void OnInspectorUpdate()
    {
        Repaint();
    }
    private void OnSelectionChange()
    {
        Repaint();
    }


    void DrawMagicAttributes()
    {
        magicScriptable.Name = EditorGUILayout.TextField("Magic Name:", magicScriptable.Name);
        EditorGUILayout.Space();
        magicScriptable.Attribute.TypeAttribute = (TypeAttribute)EditorGUILayout.EnumPopup("Atribbute", magicScriptable.Attribute.TypeAttribute);
        EditorGUILayout.Space();
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Description",GUILayout.Width(80));
        magicScriptable.Description = EditorGUILayout.TextArea(magicScriptable.Description, GUILayout.Height(150));
        EditorGUILayout.EndHorizontal();
        EditorGUILayout.Space();
    }

    void DrawTabs()
    {
        string[] options = { "Words", "Ability", "Visual Effects" };
        selected = GUILayout.Toolbar(selected, options, GUILayout.ExpandWidth(true));
        switch (selected)
        {
            case 0:
                DrawWords();
                break;
            case 1:
                DrawAbility();
                break;
            case 2:
                DrawVisualEffects();
                break;
        }
    }
    void DrawWords()
    {
        for(int i = 0; i < magicScriptable.Words.Count; i++)
        {
            Rect box = EditorGUILayout.BeginVertical();
            EditorGUILayout.Space();
            GUIStyle labelStyle = GUI.skin.GetStyle("Label");
            labelStyle.alignment = TextAnchor.MiddleCenter;
            EditorGUILayout.LabelField("Word "+(i+1), labelStyle);
            EditorGUILayout.Space();
            DrawWord(magicScriptable.Words[i]);
            EditorGUILayout.Space();
            EditorGUILayout.EndVertical();
            GUI.Box(box, GUIContent.none);
        }
    }
    void DrawWord(Word word)
    {
 
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Type Word: ", GUILayout.Width(145));
        word.TypeWord = (TypeWord)EditorGUILayout.EnumPopup(word.TypeWord);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space();

        word.WaitTime = EditorGUILayout.FloatField("Time Wait: ", word.WaitTime);

        EditorGUILayout.Space();

        word.Times = EditorGUILayout.FloatField("Times: ", word.Times);

        EditorGUILayout.Space();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Key: ", GUILayout.Width(145));
        word.Key = (KeyCode)EditorGUILayout.EnumPopup( word.Key, GUILayout.Width(100));
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space();
    }
    void DrawAbility()
    {
        EditorGUILayout.Space();
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Icon", GUILayout.Width(50));
        magicScriptable.Ability.ImageMagic = (Sprite)EditorGUILayout.ObjectField("",magicScriptable.Ability.ImageMagic, typeof(Sprite), allowSceneObjects: true, options:GUILayout.Width(90));
        EditorGUILayout.BeginVertical();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Power: ", GUILayout.Width(70));
        magicScriptable.Ability.Power = EditorGUILayout.FloatField(magicScriptable.Ability.Power);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Size: ", GUILayout.Width(70));
        magicScriptable.Ability.Size = EditorGUILayout.FloatField(magicScriptable.Ability.Size);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.EndHorizontal();
        EditorGUILayout.EndHorizontal();

        // draw effects
        EditorGUILayout.Space();
        EditorGUILayout.Space();

        DrawEffects();
    }
    void DrawEffects()
    {
        for(int i = 0; i < magicScriptable.Ability.Effects.Count; i++)
        {
            Rect rect = EditorGUILayout.BeginVertical();
            EditorGUILayout.Space();
            DrawEffect(magicScriptable.Ability.Effects[i]);
            EditorGUILayout.Space();
            EditorGUILayout.EndVertical();
            GUI.Box(rect, GUIContent.none);
            EditorGUILayout.Space();
        }
    }
    void DrawEffect(Effect.EffectControl effect)
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Type Effect: ", GUILayout.Width(85));
        effect.Effect = (TypeEffect)EditorGUILayout.EnumPopup(effect.Effect, GUILayout.Width(120));
        EditorGUILayout.EndHorizontal();

        effect.TimeDuration = EditorGUILayout.FloatField("Time Duration: ", effect.TimeDuration);
        effect.Value = EditorGUILayout.FloatField("Value: ", effect.Value);
        effect.Hits = EditorGUILayout.IntField("Hits: ", effect.Hits);
        effect.Delay = EditorGUILayout.FloatField("Delay: ", effect.Delay);
    }
    void DrawVisualEffects()
    {
        EditorGUILayout.LabelField("TO DO Effects");
    }

}
