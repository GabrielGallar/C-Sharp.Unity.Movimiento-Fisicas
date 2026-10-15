using UnityEngine;

public class LanzarMateriales5 : MonoBehaviour
{
    private Rigidbody rb;
    public float fuerza;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fuerza = 1.0f;
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.X))
        {
            rb.AddForce(Vector3.forward * fuerza);
        }
    }
}
