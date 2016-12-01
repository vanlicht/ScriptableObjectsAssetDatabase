using UnityEngine;
using System.Collections;

public class TestManager : MonoBehaviour
{
    #region Public Variable
    public static TestManager Instance;
    public DataClass curClass;
    #endregion

    #region Private Variable
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
            curClass.UpdateClass();
        }
    }

    #endregion

    #region Utility Methods
    void OnDrawGizmos() { }
    #endregion


}
