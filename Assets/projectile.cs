using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    public float vitesse = 30f;
    public int degat = 1;
    [SerializeField]
    private GameObject prefabHit;
    private GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, vitesse * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) {
        CibleReactive cibleReactive = other.GetComponent<CibleReactive>();
        if (cibleReactive != null)
        {
            explosion = Instantiate(prefabHit) as GameObject;
            Destroy(explosion, 2);
            //  ennemie.transform.position = new Vector3(0, 1, 0);
            explosion.transform.position = this.transform.position;
            cibleReactive.JeSuisTouche();
            // joueur.Touche(degat);
        }
        explosion = Instantiate(prefabHit) as GameObject;
        Destroy(explosion, 2);
        //  ennemie.transform.position = new Vector3(0, 1, 0);
        explosion.transform.position = this.transform.position;
        Destroy(this.gameObject);
    }

}
