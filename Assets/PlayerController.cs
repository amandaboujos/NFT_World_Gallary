using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private PlayerInput playerInput;

    private InputAction jumpAction;

    
    private PlayerControls playerControls;

    private void Awake()
    {
       playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    void Start()
    {
        
    }

    private void Update()
    {
       Vector2 move = playerControls.CharacterControls.Move.ReadValue<Vector2>();
        //Debug.Log(move);
        //playerControls.CharacterControls.Jump.ReadValue<float>();
        //if (playerControls.CharacterControls.Jump.ReadValue<float>() == 1)
           if (playerControls.CharacterControls.Jump.triggered)
               Debug.Log("Jump");
    }

}
