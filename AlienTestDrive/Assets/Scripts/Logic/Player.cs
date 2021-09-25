using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private VehicleEnterAreaArrayVar validVehicles;

    private bool isInside = false;

    VehicleEnterArea vehicle;

    public InputAction interactAction;
    public InputActionMap gameplayActions;

    private void Start()
    {
        gameplayActions["Interact"].performed += OnInteract;
    }

    private void OnDestroy()
    {
        gameplayActions["Interact"].performed -= OnInteract;
    }

    private void OnInteract(InputAction.CallbackContext context)
    {
        if(!isInside && validVehicles.Count() > 0 && validVehicles.Value[0] != null)
        {
            vehicle = validVehicles.Value[0];
            vehicle.EnterVehicle(transform);
            isInside = true;
        }
        else if(isInside)
        {
            vehicle.ExitVehicle(transform);
            vehicle = null;
            isInside = false;
        }
    }

    private void OnEnable()
    {
        interactAction.Enable();

        gameplayActions.Enable();
    }

    private void OnDisable()
    {
        interactAction.Disable();

        gameplayActions.Disable();
    }
}
