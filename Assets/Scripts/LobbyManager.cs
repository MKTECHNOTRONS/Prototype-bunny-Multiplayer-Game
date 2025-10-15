using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    public TMP_InputField createInput;
    public TMP_InputField joinInput;
    
    //max players per room
    public byte maxPlayers;
   
    public void CreateBtn(){
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = maxPlayers;

        PhotonNetwork.CreateRoom(createInput.text, roomOptions);
    }

    
    public void JoinBtn(){
         PhotonNetwork.JoinRoom(joinInput.text);
    }
    public override void OnJoinedRoom(){
        PhotonNetwork.LoadLevel("Main Menu");
    }
}
