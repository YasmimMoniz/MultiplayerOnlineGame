using Photon.Pun;
using UnityEngine;

public class GameManagerr : MonoBehaviourPunCallbacks
{
    public GameObject circlePrefab;
    public GameObject ballPrefab;  // Referência ao prefab da bola

    private void Start()
    {
        if (PhotonNetwork.IsConnectedAndReady)
        {
            if (PhotonNetwork.IsMasterClient)
            {
                // O jogador que cria a sala controla o Circle1
                PhotonNetwork.Instantiate(circlePrefab.name, new Vector3(-2, 0, 0), Quaternion.identity, 0);
                // Instanciar a bola no servidor
                PhotonNetwork.Instantiate(ballPrefab.name, Vector3.zero, Quaternion.identity, 0);
            }
            else
            {
                // O jogador que entra na sala controla o Circle2
                PhotonNetwork.Instantiate(circlePrefab.name, new Vector3(2, 0, 0), Quaternion.identity, 0);
            }
        }
    }
}
