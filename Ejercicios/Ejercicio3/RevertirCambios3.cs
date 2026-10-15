using UnityEngine;

public class RevertirCambios3 : MonoBehaviour
{
    private Color colorAnterior;
    private Renderer rend;
    public float daño = 0.0f;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Zona")
        {
            rend = GetComponent<Renderer>();
            colorAnterior = rend.material.color;
            rend.material.color = Color.blue; 
        }
        else
        {
            daño += 20;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Zona")
        {
            rend = GetComponent<Renderer>();
            rend.material.color = colorAnterior;
        }
        
    }
}
