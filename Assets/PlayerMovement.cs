using UnityEngine;
using Fusion;

public class PlayerMovement : NetworkBehaviour
{
    private CharacterController characterController;
    public float playerSpeed = 2;

    private void Awake()
    {
        gameObject.TryGetComponent(out characterController);
    }

    public override void FixedUpdateNetwork()
    {
        Vector3 move = new Vector3(0,0,0) * Runner.DeltaTime * playerSpeed;

        characterController.Move(move);

        if(move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
}
