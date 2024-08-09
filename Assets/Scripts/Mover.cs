using UnityEngine;

public class Mover : MonoBehaviour
{
    // ▼ "Setting" the "Move Speed" of the "Player" Game Object ▼
    [SerializeField] float moveSpeed = 10f;


    
    // ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ "Start()" Method 
    //      → is "Called Once" 
    //      → before the "First Execution" 
    //      → of "Update()" Method 
    //      → then it "Stops" ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
    void Start()
    {
        // ▼ "Calling" the "Method" ▼
        PrintInstructions();
    }


    //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ "Update()" Method  
    //  → is "Called Once" per "Frame" ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
    void Update()
    {     
        // ▼ "Calling" the "Method" ▼
        MovePlayer();
    }



    //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬  "Print Instructions" Method  ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
    void PrintInstructions() 
    {
        // ▼ "Printing" to the "Console" ▼
        Debug.Log("Welcome to the Game");
        Debug.Log("Move your Player with WASD or Arrow Keys");
        Debug.Log("Don't Hit the Walls!");
    }



    //▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬  "Move Player()" Method  ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
     void MovePlayer()
    {
       // ▼ "Accessing" the "Input Manager" from "Project Settings"
        //    → that allow to "Get Axis" 
        //    → on the "Horizontal" (pressed "Left" and "Right" Keys) and
        //    → "Vertical" (pressed "Up"/"Forward" and "Down/"Backward" Keys) Axiss ▼
        // ▼ "Multiply" the "Value" by the "DeltaTime" of the "Frame"
        //    → to "Move" the "Player" with the "Same Speed" 
        //    → regardless of "Computer Performance" 
        //    → and Make it "Frame Rate independent" ▼
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;



        // ▼ "Accessing" th ".Translate(X, Y, Z)" Method 
        //    → of "Transform" Component of "Player" Game Object 
        //    → that allow to "Move" the "Player" 
        //    → on the "X","Y","Z" Axis 
        //    → by Adding the "Value" to the "Existing Position" ▼
        transform.Translate(xValue, 0, zValue);
    }
}
