using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInput;
    public TMP_InputField joinInput;
    public TMP_Text Status_Room;
    

    // M�todo para criar uma sala
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);
    }

    // M�todo para entrar em uma sala existente
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    // M�todo chamado quando o jogador entra na sala
    public override void OnJoinedRoom()
    {
        CheckAndStartGame();
    }

    // M�todo chamado quando um novo jogador entra na sala
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {

        CheckAndStartGame();
    }

    // Verifica o n�mero de jogadores e inicia o jogo se houver pelo menos dois jogadores
    private void CheckAndStartGame()
    {
       // if (PhotonNetwork.CurrentRoom.PlayerCount >= 2)
       // {
            PhotonNetwork.LoadLevel("Game");
       // }
        //else
        //{
            Status_Room.text = " Aguardando jogador 2 ";
       // }
    }

   
}
