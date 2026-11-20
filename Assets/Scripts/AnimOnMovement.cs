using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class AnimOnMovement : MonoBehaviour
{
    public InputActionAsset movement;
    public Animator movementAnimator;


    void Update()
    {
        
        if (movement.FindAction("Move").IsPressed())
        {
            movementAnimator.SetBool("Running", true);
        }
        else
        movementAnimator.SetBool("Running", false);
    }
}
   
