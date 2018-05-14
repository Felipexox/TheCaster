using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class BookEditor : EditorWindow {
    private BookScriptable book;
    private string newName = "";
    [MenuItem("Window/Book Editor")]
    public static void CriarBookEditor()
    {
        GetWindow<BookEditor>("Book Editor");
        MagicEditor.CreateWindow();
    }
    private void OnSelectionChange()
    {
        Repaint();
    }
    private void OnInspectorUpdate()
    {
        Repaint();
    }
    private void OnGUI()
    {
 
        if(book != null)
        {
            DrawBackButton();
            if (book != null)
            {
                DrawBookEditor();
                DrawMagics();
                DrawAddMagic();
            }
        }
        else
        {
            List<BookScriptable> allBooks = getAllBooks();
            DrawAllBooks(allBooks);
            DrawAddBook();
        }
    }
    private void DrawBackButton()
    {
        EditorGUILayout.Space();
        if (GUILayout.Button("<-", GUILayout.Width(40)))
        {
            Object[] objs = { };
            Selection.objects = objs;
            book = null;
        }
    }
    #region Books
    private void DrawAddBook()
    {

        newName = EditorGUILayout.TextField("Name Book", newName);
        if (GUILayout.Button("+") && !string.IsNullOrEmpty(newName))
        {
            BookScriptable bookAsset = (BookScriptable)ScriptableObject.CreateInstance<BookScriptable>();
            bookAsset.Name = newName;
            string path = "";
            path = "Assets/Assets/MagicBooks/Books/";
            path = AssetDatabase.GenerateUniqueAssetPath(path + "/" + newName + ".asset");
            AssetDatabase.CreateAsset(bookAsset, path);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            newName = "";
        }
    }
    private List<BookScriptable> getAllBooks()
    {
        List<BookScriptable> books = new List<BookScriptable>();
        Object[] bookObjects = Resources.FindObjectsOfTypeAll(typeof(BookScriptable));
        foreach(Object obj in bookObjects)
        {
            books.Add((BookScriptable)obj);
        }
        return books;
    }
    private void DrawAllBooks(List<BookScriptable> books)
    {
        foreach(BookScriptable book in books)
        {
            EditorGUILayout.Space();
            DrawBook(book);
            EditorGUILayout.Space();
        }

    }
    private void DrawBook(BookScriptable book)
    {
        Rect rect = EditorGUILayout.BeginVertical();
        EditorGUILayout.BeginHorizontal();
        string bookName = string.IsNullOrEmpty(book.Name)? book.name : book.Name;
        EditorGUILayout.LabelField(bookName);

        if (GUILayout.Button("Select"))
        {
            this.book = book;
        }

        EditorGUILayout.EndHorizontal();
        EditorGUILayout.EndVertical();
    }
    private void DrawBookEditor()
    {
        if (book != null)
        {
            book.Name = EditorGUILayout.TextField("Name Book: ", book.Name);
            if(!string.IsNullOrEmpty(book.Name))
              book.name = book.Name;
        }
    }
    #endregion

    #region Magics
    private void DrawAddMagic()
    {
     
        newName = EditorGUILayout.TextField("Name Magic", newName);
        if (GUILayout.Button("+") && !string.IsNullOrEmpty(newName))
        {
            MagicScriptable magic = (MagicScriptable)ScriptableObject.CreateInstance<MagicScriptable>();
            magic.Name = newName;
            string path = "";
            path = "Assets/Assets/MagicBooks/Magics/";
            path = AssetDatabase.GenerateUniqueAssetPath(path+"/"+newName+".asset");
            AssetDatabase.CreateAsset(magic, path);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            book.Magics.Add(magic);
            newName = "";
        }
    }
    private void DrawMagics()
    {

        for (int i = 0; i < book.Magics.Count; i++)
        {
            EditorGUILayout.Space();
            DrawMagic(book.Magics[i]);
            EditorGUILayout.Space();
        }
        
    }
    private void DrawMagic(MagicScriptable magic)
    {
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField(magic.Name);
        if (GUILayout.Button("Select"))
        {
            MagicEditor.magicScriptable = magic;
        }
        EditorGUILayout.EndHorizontal();

    }
    #endregion
}
