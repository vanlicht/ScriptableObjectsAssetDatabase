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

    public Vector3 myTransform;
    public Vector3 myRotation;
    public Vector3 myScale;
#endregion

#region Private Variable
#endregion

#region Main Methods
    public void StartClass()
    {
        Debug.Log("Started Class...");
    }

    public void UpdateClass(Vector3 TransformValue, Vector3 RoatationValue, Vector3 ScaleValue)
    {
        Debug.Log("Updating Class...");
        myTransform = TransformValue;
        myRotation = RoatationValue;
        myScale = ScaleValue;
    }
    #endregion

    #region Editor GUI
#if UNITY_EDITOR
    public void OnDrawEditorGUI()
    {
        //myColor = EditorGUILayout.ColorField("My Color: ", myColor);
        //myFloat = EditorGUILayout.FloatField("My Float: ", myFloat);
        //GUILayout.Space(10);
        //curText = EditorGUILayout.TextArea(curText, GUILayout.Height(100));
        myTransform = EditorGUILayout.Vector3Field("Position", myTransform);
        myRotation = EditorGUILayout.Vector3Field("Rotateion", myRotation);
        myScale = EditorGUILayout.Vector3Field("Scale", myScale);
        //set this so when restart Unity the data is retained
        EditorUtility.SetDirty(this);
    }
#endif
#endregion

    #region Utility Methods
    #endregion
}
