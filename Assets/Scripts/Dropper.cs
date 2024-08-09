using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dropper : MonoBehaviour
{
    // ▼ "References" to the "Components" in the "Inspector" 
    //    → of "Dropper" Game Object ▼
    MeshRenderer renderer; 
    Rigidbody rigidbody;


    // ▼ "Variable" as "Serialize Field" to be "Visible" in the "Inspector" ▼
    [SerializeField] float timeToWait = 5f;



    // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ "Start()" Method ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
    void Start()
    {
        // ▼ "Getting" the "Components" of the "Dropper" Game Object ▼
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        // ▼ "Accessing" the "Mesh Renderer" Component 
        //    → and "Set its "Enabled" Property to "False" ("Disable"/"Invisible") ▼
        renderer.enabled = false;

        // ▼ "Accessing" the "Rigidbody" Component 
        //    → and "Set" its "Use Gravity" Property to "False" ("Disable"/"Invisible") ▼
        rigidbody.useGravity = false;
    }





    // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ "Update()" Method ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
    void Update()
    {
        // ▼ "Checking" if "Time To Wait" has "Passed" ▼
        if(Time.time > timeToWait)
        {          
            // ▼ "Accessing" the "Mesh Renderer" Component 
            //    → and "Reset" its "Enabled" Property  to "True" ("Enable"/"Visible") ▼
            renderer.enabled = true;

            // ▼ "Accessing" the "Rigidbody" Component 
            //    → and "Reset" its "Use Gravity" Property to "True" ("Enable"/"Visible") ▼
            rigidbody.useGravity = true;

        }       
    }
}
