using UnityEngine;

public class buildmove : MonoBehaviour
{
   public Rigidbody rb;
        public Transform ground;
        public float fowardForce = -2000f;
        public double deadZone = -42;
        void Update()
        {
             rb.AddForce(0 , 0, fowardForce * Time.deltaTime);

             if (transform.position.z < deadZone)
             {
                Destroy(gameObject);
             }
        }
}
