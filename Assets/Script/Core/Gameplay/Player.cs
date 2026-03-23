using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    [Header("Player Stats")]
    
    [field:SerializeField] public PlayerCurveMovement playerCurveMovement { get; private set; }
    [field:SerializeField] public Health health { get; private set; }
}
