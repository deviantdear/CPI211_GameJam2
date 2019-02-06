using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private bool isWalking;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;

    public CharacterController characterController;

}
