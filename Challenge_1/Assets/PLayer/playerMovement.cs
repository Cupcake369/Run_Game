using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float sideForce = 500f;
    // Update is called once per frame
    void Update()
    {

        if( Input.GetKey("d") )
        {
            rigidbody.AddForce(sideForce * Time.deltaTime, 0, 0 );
        }

        if( Input.GetKey("a") )
        {
            rigidbody.AddForce(-sideForce * Time.deltaTime, 0, 0 );
        }
    }
}
