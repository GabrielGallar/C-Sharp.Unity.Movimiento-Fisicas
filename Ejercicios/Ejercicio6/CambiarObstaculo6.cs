using UnityEngine;

public class CambiarObstaculo6 : MonoBehaviour
{
    private Transform posicionDestino;
    private Collider colliderObs;
    private GameObject obstaculo;
    private PhysicsMaterial nuevoMaterialFisico;
    private Material nuevoMaterialVisual;
    void Start()
    {
        GameObject destino = GameObject.FindWithTag("Cilindro");
        obstaculo = GameObject.FindWithTag("Obstaculo");
        colliderObs = obstaculo.GetComponent<Collider>();
        posicionDestino = destino.transform;
        //Creando el material físico
        nuevoMaterialFisico = new ("Equilibrado");
        nuevoMaterialFisico.dynamicFriction = 0.5f;   
        nuevoMaterialFisico.staticFriction = 0.5f;    
        nuevoMaterialFisico.bounciness = 0.5f;
        nuevoMaterialFisico.frictionCombine = PhysicsMaterialCombine.Average;
        nuevoMaterialFisico.bounceCombine = PhysicsMaterialCombine.Average;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, posicionDestino.position, 1 * Time.deltaTime);
        if (Vector3.Distance(transform.position, obstaculo.transform.position) < 1.0f)
        {
            //Material Físico
            colliderObs.material = nuevoMaterialFisico;
            //Material Visual
            Renderer rend = obstaculo.GetComponent<Renderer>();
            rend.material = nuevoMaterialVisual;
            nuevoMaterialVisual = new Material(Shader.Find("Decal"));
            rend.material = nuevoMaterialVisual;
        }
    }
}
