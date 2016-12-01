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
            targetMgr.curClass = GetClass();
        }
    }

    public override void OnInspectorGUI()
    {
        //DrawDefaultInspector();
        EditorGUILayout.BeginHorizontal();
        GUILayout.Space(10);
        EditorGUILayout.BeginVertical();
        GUILayout.Space(10);
        if (targetMgr.curClass != null)
        {
            targetMgr.curClass.OnDrawEditorGUI();
        }
        GUILayout.Space(10);
        EditorGUILayout.EndVertical();
        GUILayout.Space(10);
        EditorGUILayout.EndHorizontal();
        
    }
    #endregion

    #region Utility Methods
    DataClass GetClass()
    {
        DataClass curClass = (DataClass)AssetDatabase.LoadAssetAtPath(path, typeof(DataClass));
        if(curClass != null)
        {
            return curClass;
        }
        else
        {
            //create it
            return CreateClass();
        }
    }

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
