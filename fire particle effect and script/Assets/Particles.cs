using UnityEngine;
using System.Collections;

public class Particles : MonoBehaviour
{
    private ParticleSystem ps;
    [Range(0.0f, 10.0f)]
    [SerializeField] float Xvalue = 1.0f;
    [Range(0.0f, 10.0f)]
    [SerializeField] float Yvalue = 1.0f;
    [Range(0.0f, 10.0f)]
    [SerializeField] float Zvalue = 1.0f;  
    //[Range(0.0f, 1.0f)]
    //[SerializeField] float alpha = 0.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ps = GetComponent<ParticleSystem>();

        var main = ps.main;
        main.startSize3D = true;

        var psr = GetComponent<ParticleSystemRenderer>();
        psr.renderMode = ParticleSystemRenderMode.Mesh;
        psr.mesh = Resources.GetBuiltinResource<Mesh>("Sphere.fbx"); 
        psr.material = new Material(Shader.Find("Sprites/Default"));
        // Particle System modules do not need to be reassigned back to the system.
        // they are interfaces and not independent objects.
    }

    // Update is called once per frame
    void Update()
    {
        //ps.startColor = new Color(colorRed, colorGreen, colorBlue, alpha);
        var main = ps.main;
        main.startSizeXMultiplier = Xvalue;
        main.startSizeYMultiplier = Yvalue;
        main.startSizeZMultiplier = Zvalue;
        //Debug.Log(Xvalue);
        //Debug.Log(Yvalue);
        //Debug.Log(Zvalue);
    }
}
