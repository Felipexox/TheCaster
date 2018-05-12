
using UnityEngine;
using UnityEditor;
public class MagicEditor : EditorWindow {
    public MagicScriptable magicScriptable;
    private float sizeX = 500, sizeY = 600;
    int selected = 0;
    [MenuItem("Window/BookEditor")]
    public static void CreateWindow()
    {
        GetWindow<MagicEditor>("Magic Editor");
    }
    private void OnGUI()
    {
        minSize = new Vector2(sizeX, sizeY);
       
        magicScriptable = Selection.objects[0] as MagicScriptable;
        if (magicScriptable != null)
        {
            DrawMagicAttributes();
            DrawTabs();
        }
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
        string[] options = { "Words", "Ability", "Effects" };
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
                DrawEffects();
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
       
    }

    void DrawEffects()
    {
        EditorGUILayout.LabelField("TO DO Effects");
    }

}
