using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntelligenceErrante : MonoBehaviour
{

    [SerializeField]
    public GameObject prefabProjectile;

    private GameObject projectile;

    public float vitesse = 3.0f;
    public float distanceObstacle = 5.0f;
    public bool EnVie = true;

    private GameObject j;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnVie) {
            transform.Translate(0, 0, vitesse * Time.deltaTime);
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.SphereCast(ray, 0.75f, out hit,10000))
            {

                if (hit.distance < distanceObstacle)
                {
                    float angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }

            
        }

      
    }


}
