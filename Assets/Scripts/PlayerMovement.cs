using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int Speed = 5;
    private CharacterController Player;
    private Vector3 DirectionDeplacement;
    public int Sensisbility;
    public int Jump = 5;
    public int Gravity = 20; 
    
    void Start()
    {
        Player = GetComponent<CharacterController>();
    }


    private void Update()
    {
        DirectionDeplacement.x = Input.GetAxisRaw("Vertical");
        DirectionDeplacement.z = Input.GetAxisRaw("Horizontal");
        DirectionDeplacement = transform.TransformDirection(DirectionDeplacement);

        //Deplacement CHaracter Clavier
        Player.Move(DirectionDeplacement * Time.deltaTime * Speed);

        //Rotation Souris
        transform.Rotate(0, Input.GetAxisRaw("Mouse X")*Sensisbility,0);

        //Saut
        if (Input.GetKeyDown(KeyCode.Space) && Player.isGrounded)
        {
            DirectionDeplacement.y = Jump;
        }
        //Gravité
        if (!Player.isGrounded)
        {
            DirectionDeplacement.y -= Gravity * Time.deltaTime;  
        }
    }
}
 