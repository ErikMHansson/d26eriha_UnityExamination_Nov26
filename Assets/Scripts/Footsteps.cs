using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Footsteps : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    public InputActionAsset movement;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (movement.FindAction("Move").IsPressed())
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
}

