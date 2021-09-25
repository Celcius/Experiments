using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AmoaebaUtils;

[RequireComponent(typeof(VehicleEnterArea))]
public class VehicleEnterAreaTrigger : ScriptArrayVarTrigger<VehicleEnterArea, VehicleEnterAreaArrayVar>
{

    protected override bool CheckValidity(Collider other, bool isEnter)
    {
        return other.tag.CompareTo(GameConstants.PLAYER_TAG) == 0;
    }

    protected override bool CheckValidity(Collider2D other, bool isEnter)
    {
        return  other.tag.CompareTo(GameConstants.PLAYER_TAG) == 0;
    }
}
