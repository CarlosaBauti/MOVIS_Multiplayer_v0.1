using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LoginManager : MonoBehaviourPunCallbacks
{
    #region Unity Methods
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion UI Callback Methods
    public void ConnectAnonymously()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    #region

    #endregion
    #region
    public override void OnConnected()
    {
        Debug.Log("OnConnected is called. The server is available");
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master server");
        PhotonNetwork.LoadLevel("Main");
    }
    #endregion
}
