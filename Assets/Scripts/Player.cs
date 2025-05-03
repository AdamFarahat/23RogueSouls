using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    //This script will be used to control the player character in the game as well as manage the player's stats.
    [SerializeField] float speed = 5f; // Speed of the player character
    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 input = context.ReadValue<Vector2>(); // Get the input value from the Input System
        Vector3 move = new Vector3(input.x, 0, input.y); // Create a new Vector3 for movement
        if(move != Vector3.zero) // Check if the input is not zero
        {
            transform.Translate(move * speed * Time.deltaTime); // Move the player character
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
