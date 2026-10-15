using UnityEngine;

public class MoverRigidbody1 : MonoBehaviour
{
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Vector3 posicion = new (Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
            rb.MovePosition(rb.position + posicion * Time.fixedDeltaTime);
        }
    }
}
