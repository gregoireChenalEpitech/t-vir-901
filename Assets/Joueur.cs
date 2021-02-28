using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    private int sante;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Touche(int dommage)
    {
        sante -= dommage;
        Debug.Log("Sante : " + sante);
    }

}
