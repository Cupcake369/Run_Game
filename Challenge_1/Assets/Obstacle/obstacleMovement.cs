using UnityEngine;

public class obstacleMovement : MonoBehaviour
{
        public Rigidbody rb;
        public Transform enemy;
        public float fowardForce = -2000f;
        public double deadZone = -4;
        void Update()
        {
             rb.AddForce(0 , 0, fowardForce * Time.deltaTime);

             if (transform.position.z < deadZone)
             {
                Destroy(gameObject);
             }
        }
       
}
