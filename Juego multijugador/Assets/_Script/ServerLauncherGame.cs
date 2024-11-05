using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ServerLauncherGame : MonoBehaviourPunCallbacks
{
    public PhotonView player;
    public Transform spawn;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Conectado al Master Server.");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Se ha unido a una sala.");
        PhotonNetwork.Instantiate(player.name, spawn.position, spawn.rotation);
    }
}