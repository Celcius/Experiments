using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AmoaebaUtils;

public class VehicleEnterArea : MonoBehaviour
{
    [SerializeField]
    private Transform insideAnchor;

    [SerializeField]
    private Transform outsideAnchor;

    public void EnterVehicle(Transform transform)
    {
        transform.position = insideAnchor.position;
    }

    public void ExitVehicle(Transform transform)
    {
        transform.position = insideAnchor.position;
    }
}
