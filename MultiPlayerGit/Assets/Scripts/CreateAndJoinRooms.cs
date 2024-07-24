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
    

    // Método para criar uma sala
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);
    }

    // Método para entrar em uma sala existente
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    // Método chamado quando o jogador entra na sala
    public override void OnJoinedRoom()
    {
        CheckAndStartGame();
    }

    // Método chamado quando um novo jogador entra na sala
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {

        CheckAndStartGame();
    }

    // Verifica o número de jogadores e inicia o jogo se houver pelo menos dois jogadores
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
