using System.Collections;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    #region Assign IDs to tablet players and activate Joined Room Panel
    public GameObject JoinedRoomPanel;

    public void ClickedOne()
    {
        PhotonNetwork.NickName = "11";
        StartCoroutine(EnableJoinedRoomPanelAfterFewSeconds()); //Wait for few seconds to connect to server
    }
    public void ClickedTwo()
    {
        PhotonNetwork.NickName = "12";
        StartCoroutine(EnableJoinedRoomPanelAfterFewSeconds()); //Wait for few seconds to connect to server
    }
    public void ClickedThree()
    {
        PhotonNetwork.NickName = "13";
        StartCoroutine(EnableJoinedRoomPanelAfterFewSeconds()); //Wait for few seconds to connect to server
    }

    public void ClickedFour()
    {
        PhotonNetwork.NickName = "14";
        StartCoroutine(EnableJoinedRoomPanelAfterFewSeconds()); //Wait for few seconds to connect to server
    }

    public void ClickedFive()
    {
        PhotonNetwork.NickName = "15";
        StartCoroutine(EnableJoinedRoomPanelAfterFewSeconds()); //Wait for few seconds to connect to server
    }

    public void ClickedSix()
    {
        PhotonNetwork.NickName = "16";
        StartCoroutine(EnableJoinedRoomPanelAfterFewSeconds()); //Wait for few seconds to connect to server
    }

    public void ClickedSeven()
    {
        PhotonNetwork.NickName = "17";
        StartCoroutine(EnableJoinedRoomPanelAfterFewSeconds()); //Wait for few seconds to connect to server
    }

    public void ClickedEigth()
    {
        PhotonNetwork.NickName = "18";
        StartCoroutine(EnableJoinedRoomPanelAfterFewSeconds()); //Wait for few seconds to connect to server
    }

    public void ClickedNine()
    {
        PhotonNetwork.NickName = "19";
        StartCoroutine(EnableJoinedRoomPanelAfterFewSeconds()); //Wait for few seconds to connect to server
    }

    public void ClickedTen()
    {
        PhotonNetwork.NickName = "20";
        StartCoroutine(EnableJoinedRoomPanelAfterFewSeconds()); //Wait for few seconds to connect to server
    }

    IEnumerator EnableJoinedRoomPanelAfterFewSeconds()
    {
        yield return new WaitForSeconds(2.5f);
        JoinedRoomPanel.SetActive(true);
    }
    #endregion

    #region Photon Connect to Server
    public void ConnectToServer()
    {
        PhotonNetwork.ConnectUsingSettings();

        if (UserTypeManager.userType)// user type true if for tablet users
        {
            //if user is tablet user do nothing
        }
        else //if user is HMD user
        {
            PhotonNetwork.NickName = "HMD User Network Player";
        }

        Debug.Log("Try Connect to server...");
    }
    #endregion

    #region Photon Callback functions and JoinLobby
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to server");
        base.OnConnectedToMaster();

        PhotonNetwork.JoinLobby(); // if the server is connected, automatically join the lobby
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        Debug.Log("Joined Lobby");

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            //do nothing
        }
        else
        {
            PhotonNetwork.LoadLevel(0); // go back to lobby
        }
    }
    #endregion
}
