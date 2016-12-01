using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using System;
using System.Collections;

[Serializable]
public class DataClass : ScriptableObject
{

#region Public Variable
    public float myFloat = 1.0f;
    public Color myColor = Color.white;
    public string curText = "Enter Text Here...";
#endregion

#region Private Variable
#endregion

#region Main Methods
    public void StartClass()
    {
        Debug.Log("Started Class...");
    }

    public void UpdateClass()
    {
        Debug.Log("Updating Class...");
    }
    #endregion

    #region Editor GUI
#if UNITY_EDITOR
    public void OnDrawEditorGUI()
    {
        myColor = EditorGUILayout.ColorField("My Color: ", myColor);
        myFloat = EditorGUILayout.FloatField("My Float: ", myFloat);
        GUILayout.Space(10);
        curText = EditorGUILayout.TextArea(curText, GUILayout.Height(100));

        //set this so when restart Unity the data is retained
        EditorUtility.SetDirty(this);
    }
#endif
#endregion

    #region Utility Methods
    #endregion
}
