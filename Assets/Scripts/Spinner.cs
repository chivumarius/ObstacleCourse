using UnityEngine;

public class Spinner : MonoBehaviour
{   
    // ▼ "Variables Displays" in the "inspector" ▼
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 0f;
    [SerializeField] float zAngle = 0f;



    //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ "Update()" Method ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ 
    void Update()
    {
        // ▼ "Accessing" the "Transform" Component of the "Spinner" Game Object  
        //    → and "Rotate" it ▼
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
