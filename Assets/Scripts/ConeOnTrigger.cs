using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeOnTrigger : MonoBehaviour {

	 public ZombieAi zombieAi;
	public PlayerController player;
 
   
    void OnTriggerEnter2D(Collider2D o)
    {
        
        if (o.gameObject.tag == "Player")
        {
            zombieAi.inViewCone = true;
	    player.dec_health =1;
        }
	
    }
    
    void OnTriggerExit2D(Collider2D o)
    {
 
 
        if (o.gameObject.tag == "Player")
        {
            zombieAi.inViewCone = false;
	     player.dec_health =0;
        }
	
    }
}
