using UnityEngine;
using System.Collections;

public class TestManager : MonoBehaviour
{
    #region Public Variable
    public static TestManager Instance;
    public DataClass curClass;
    #endregion

    #region Private Variable
    Vector3 TransformValue;
    Vector3 RotationValue;
    Vector3 ScaleValue;
    #endregion

    #region Main Methods
    // Use this for initialization
    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        if(curClass != null)
        {
            curClass.StartClass();
        } 
    }

    // Update is called once per frame
    void Update()
    {
        if (curClass != null)
        {
            TransformValue = this.gameObject.transform.localPosition;
            RotationValue = this.gameObject.transform.localEulerAngles;
            ScaleValue = this.gameObject.transform.localScale;
            curClass.UpdateClass(TransformValue, RotationValue, ScaleValue);
        }
    }
#endregion

    #region Utility Methods
    void OnDrawGizmos() { }
    #endregion


}
