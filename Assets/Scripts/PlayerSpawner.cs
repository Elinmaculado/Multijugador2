using Fusion;
using UnityEngine;

public class PlayerSpawner : SimulationBehaviour, IPlayerJoined
{
    public GameObject playerPrefab;

    public void PlayerJoined(PlayerRef player)
    {
        //Runner es el Network Manager
        if(player == Runner.LocalPlayer)
        {
            Runner.Spawn(playerPrefab, Vector3.up, Quaternion.identity,player);
        }
    }
}
