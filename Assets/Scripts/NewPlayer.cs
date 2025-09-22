using System;
using UnityEngine;
using Fusion;

public class NewPlayer : NetworkBehaviour
{
    private InputSystem_Actions inputSystemActions;


    private void Awake()
    {
        inputSystemActions = new InputSystem_Actions();
        inputSystemActions.Player.Enable();
    }

    public override void FixedUpdateNetwork()
    {
        base.FixedUpdateNetwork();
        bool foo = inputSystemActions.Player.Interact.triggered;
        if (Object.HasInputAuthority && foo)
        {
            RPC_CallTrafficLight();
        }
    }

    [Rpc(RpcSources.InputAuthority, RpcTargets.All)]
    public void RPC_CallTrafficLight()
    {
        ObjectManager.singleton.trafficLight.ChangeColor();
    }
}
