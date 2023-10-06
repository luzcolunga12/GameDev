using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jForce= 3f;
    public float gDistance = 0.5f; 

    Rigidbody rb; 
    bool cDJump; 
    // Start is called before the first frame update
    private void Awake() {
        rb = GetComponent<Rigidbody>(); 
    }
    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, gDistance);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(IsGrounded())
            {
               rb.velocity = Vector3.up * jForce;
               cDJump = true;
            }
            else if(cDJump)
            {
                rb.velocity = Vector3.up * jForce;
                cDJump = false;
            }
        }
        
    }
}
