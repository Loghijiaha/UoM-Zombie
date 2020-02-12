using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyOnTrigger : MonoBehaviour {

	public PlayerController player;
 
   
    void OnTriggerEnter2D(Collider2D o)
    {
        
        if (o.gameObject.tag == "Player")
        {
            player.speed=.1f;
	    player.inc = 0;
        }
    }
    
    void OnTriggerExit2D(Collider2D o)
    {
 
 
        if (o.gameObject.tag == "Player")
        {
            player.speed=4f;
	    player.inc = 3;
        }
    }
}
