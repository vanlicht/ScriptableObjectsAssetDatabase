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
    void Start()
    {
        Instance = this; 
    }

    // Update is called once per frame
    void Update()
    {

    }

    #endregion

    #region Utility Methods
    void OnDrawGizmos() { }
    #endregion


}
