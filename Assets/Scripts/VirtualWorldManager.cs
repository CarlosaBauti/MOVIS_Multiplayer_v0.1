using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class VirtualWorldManager : MonoBehaviourPunCallbacks
{
    #region Callback Methods
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log("Player with ID :" + newPlayer.NickName + " joined to " +
            PhotonNetwork.CurrentRoom.Name + " Player count: " +
            PhotonNetwork.CurrentRoom.PlayerCount);
    }
    #endregion
}
