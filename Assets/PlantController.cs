using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform plant;
    [SerializeField] GameObject trigger;
    PlayerEntersZone checker;
    Transform triggerMove;
    void Start()
    {
        triggerMove = trigger.GetComponent<Transform>();
        checker = trigger.GetComponent<PlayerEntersZone>();
    }

    public void Grow()
    {
        if(checker.canPlant == true)
        {
            transform.position += new Vector3(0,0.25f, 0);
            plant.localScale += new Vector3(0,0.5f,0);
            triggerMove.localScale += new Vector3(0,0.5f,0);
        }
    }
}
