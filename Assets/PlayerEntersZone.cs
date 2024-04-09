using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntersZone : MonoBehaviour
{
    public bool canPlant;
    PlayerController player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            canPlant = true;
            player.canClimb = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            canPlant = false;
            player.canClimb = false;
        }
    }
}
