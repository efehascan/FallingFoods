
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    float speed = 5.0f;
    private float horizontalInput;
    void Start()
    {
        
    }
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
}
