using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(TestManager))] 
public class TestManagerEditor : Editor
{
    #region Public Variable
    TestManager targetMgr;
    string path = "Assets/Database/Data.asset";
    #endregion

    #region Private Variable
    #endregion

    #region Main Methods
    // Use this for initialization

    void OnEnable()
    {
        targetMgr = (TestManager)target;
        if(targetMgr.curClass == null)
        {
            targetMgr.curClass = CreateClass();
        }
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        //EditorUtility.SetDirty(targetMgr);
        //EditorGUILayout.BeginHorizontal();
        //GUILayout.Space(10);
        //EditorGUILayout.BeginVertical();
        //GUILayout.Space(10);

        //targetMgr.myFloat = EditorGUILayout.FloatField("My Float: ", targetMgr.myFloat);
        //targetMgr.myColor = EditorGUILayout.ColorField("My Color: ", targetMgr.myColor);

        //GUILayout.Space(10);
        //EditorGUILayout.EndVertical();
        //GUILayout.Space(10);
        //GUILayout.EndHorizontal();
    }
    #endregion
    #region Utility Methods
    DataClass CreateClass()
    {
        DataClass curClass = (DataClass)ScriptableObject.CreateInstance(typeof(DataClass));
        if(curClass != null)
        {
            AssetDatabase.CreateAsset(curClass, path);
            AssetDatabase.Refresh();
            AssetDatabase.SaveAssets();
            return curClass;
        }
        else
        {
            return null;
        }
    }
    #endregion

}
