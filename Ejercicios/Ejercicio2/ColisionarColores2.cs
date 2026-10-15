using UnityEngine;

public class ColisionarColores2 : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = Color.red;
    }

}
