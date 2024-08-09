using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scorer : MonoBehaviour
{
    // ▼ "Varialble" ▼
    int hits = 0;
    

    //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬  "On Collision Enter()" Method  ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
    private void OnCollisionEnter(Collision other) 
    {
        // ▼ "Checking" if the "Player Collided" with the "Other Game Object" 
        //      → that was  "Not Already Hit" ▼
        if(other.gameObject.tag != "Hit")
        {
            // ▼ "Incrementing" the "Value" of "Hits" ▼
            hits++;
            
            // ▼ "Printing" to the "Console" ▼
            Debug.Log("You hit one thing so many times: " + hits);
        }
    }
}
