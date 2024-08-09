using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectHit : MonoBehaviour
{
    //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬  "On Collision Enter()" Method  ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
    private void OnCollisionEnter(Collision other) 
    {
        // ▼ "Checking" if the "Player Collided" with the "oTHER Game Object" ▼
        if(other.gameObject.tag == "Player")
        {

            // ▼ "Getting" the "Mesh Renderer" Component of the "Wall" Game Object 
            //      → and "Accessing" the "Material" Property 
            //      → to "Change" its "Color" into "Red" ▼
            GetComponent<MeshRenderer>().material.color = Color.red;

            // ▼ "Accessing" the "Tag" Property of the "Other Game Objects" 
            //      → and "Setting" it with  "Untaggedg" Value  of "Tag" 
            //      → and "Set it" to "Hit" Value  ▼
            gameObject.tag = "Hit";
        }
    }
}
