using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    private Camera camera;
    public GameObject prefabProjectile;

    private GameObject projectile;

    public float coolDown = 2;
    public float coolDownTimer;

    public static int compteur = 0;
    public static int meilleurScore = 0;

    void Start()
    {
        camera = GetComponent<Camera>();

    }

    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {

        if (coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }

        if (coolDownTimer < 0 )
        {
            coolDownTimer = 0;
        }


            Vector3 point = new Vector3(
                camera.pixelWidth / 2,
                camera.pixelHeight / 2, 0);

            Ray ray = camera.ScreenPointToRay(point);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)){
            GameObject hitObject = hit.transform.gameObject;
            CibleReactive cible = hitObject.GetComponent<CibleReactive>();

          //  if (cible == null) {
               // StartCoroutine(CubeIndicator(hit.point));
            //}
            //else { 
            //    cible.JeSuisTouche();
            //}

            if (Physics.SphereCast(ray, 0.75f, out hit, 10000))
            {
               // Debug.Log("Jtest");
                if (hit.transform.gameObject.GetComponent<CibleReactive>())
                {
                  //  IntelligenceErrante ie = GetComponent<IntelligenceErrante>();
                    if (coolDownTimer == 0 && hit.transform.gameObject.GetComponent<IntelligenceErrante>().EnVie)
                    {
                       // projectile = Instantiate(prefabProjectile);
                    // projectile.transform.position = transform.TransformPoint(Vector3.forward);
                  //  projectile = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
                   // projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 50);
                     //  projectile.transform.rotation = transform.rotation;

                        projectile = GameObject.Instantiate(prefabProjectile, transform.position, transform.rotation);

                        projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 100);
                        coolDownTimer = coolDown;
                    }
                 }
            }

        }
       // }
    }

    private IEnumerator CubeIndicator(Vector3 pos) {
        GameObject cube = GameObject.CreatePrimitive(
            PrimitiveType.Cube);
        cube.transform.position = pos;
        yield return new WaitForSeconds(3);
        Destroy(cube);
    }
}
