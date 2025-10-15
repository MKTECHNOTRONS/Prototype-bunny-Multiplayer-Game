using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform spawnPoint;
    // Start is called before the first frame update


    PlayerFollow playerFollow;
    private void Awake() {
        playerFollow = FindObjectOfType<PlayerFollow>();
    }

    private void start(){
        SpawnPlayer();
    }

    void SpawnPlayer(){
        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint.position, spawnPoint.rotation);

        playerFollow.SetCameraTarget(player.transform);
    }
}
