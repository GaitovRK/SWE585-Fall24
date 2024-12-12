using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Vector3 direction = Vector3.forward; // Ensure this is not Vector3.zero

    private bool isEnabled;
    // Start is called before the first frame update
    private void Update()
    {
        if (!isEnabled)
        {
            return;
        }
        Debug.Log("Direction: " + direction);
        Debug.Log("Speed: " + speed);
        Debug.Log("DeltaTime: " + Time.deltaTime);
        Debug.Log("Translation: " + (direction * speed * Time.deltaTime));
    
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void Enable()
    {
        isEnabled = true;
    }  

    public void Disable()
    {
        isEnabled = false;
    }
}
