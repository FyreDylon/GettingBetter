using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    CharacterInteract characterInteract;
    PlayerMovement playerMovement;
    Vector3 moveVector;
    // Start is called before the first frame update
    private void Awake()
    {
        characterInteract = GetComponent<CharacterInteract>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");

        playerMovement.AddMoveVectorInput(moveVector);

        if(Input.GetMouseButtonDown(1))
        {
            characterInteract.Interact();
        }
    }
}
