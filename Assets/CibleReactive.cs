using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CibleReactive : MonoBehaviour
{
    public int nbEnnemieTue = 0;
   // public int meilleureScore = 0;


    void Start()
    {
        Text txt1 = GameObject.Find("numericalScore").GetComponent<Text>();
        if (txt1.text == "Score : 0" && RayCaster.compteur != 0)
        {
            Debug.Log("Meilleure score " + RayCaster.meilleurScore);
            Debug.Log("Compteur " + RayCaster.compteur);
            if (RayCaster.meilleurScore < RayCaster.compteur) {
                RayCaster.meilleurScore = RayCaster.compteur ;
               
            }
            Text txt2 = GameObject.Find("numericalScore2").GetComponent<Text>();
            txt2.text = "Meilleure Score : " + RayCaster.meilleurScore;
            RayCaster.compteur = 0;
           // Debug.Log("Deuxième partie");
        }
    }

    internal void JeSuisTouche()
    {
         IntelligenceErrante ie = GetComponent<IntelligenceErrante>();
       
          ie.EnVie = false;
           StartCoroutine(JeMeurt());
        Debug.Log("cible reactive touché");

    }

    private IEnumerator JeMeurt()
    {
        nbEnnemieTue = nbEnnemieTue + 1;

        RayCaster.compteur = RayCaster.compteur + 1;
        Text txt1 = GameObject.Find("numericalScore").GetComponent<Text>();
        txt1.text = "Score : " + RayCaster.compteur;

        //GetComponent<numericalScore>().text = "Score : " + nbEnnemieTue;

        Debug.Log(nbEnnemieTue);
        //color = Color.red;

       // transform.Translate(0, 0.4f, 0);
       // transform.Rotate(-90, 0, 0);
        yield return new WaitForSeconds(0);
        Destroy(gameObject);
    }
}
