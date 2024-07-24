using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class ConectToServer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("conectando");
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }


    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
        Debug.Log("carregar cena");
    }
}
