using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginUIManager : MonoBehaviour
{
    public GameObject ConnectOptionsPanelGameobject;
    public GameObject ConnectWithMobilePanelGameobject;

    #region Unity Methods

    // Start is called before the first frame update
    void Start()
    {
        ConnectOptionsPanelGameobject.SetActive(true);
        ConnectWithMobilePanelGameobject.SetActive(false);
    }
    #endregion
}
