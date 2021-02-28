using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleurScene : MonoBehaviour
{

    [SerializeField]
    private GameObject prefabEnnemi;

    private GameObject ennemie;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ennemie == null)
        {
            ennemie = Instantiate(prefabEnnemi) as GameObject;
            //  ennemie.transform.position = new Vector3(0, 1, 0);
            ennemie.transform.position = this.transform.position;
            //float angle = Random.Range(0, 360);
            //ennemie.transform.Rotate(0, angle, 0);

        }
    }


}
