using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class targets : MonoBehaviour
{
    public Transform[] target;
    public float speed;
    private int current;

    // Update is called once per frame
    void Update()
    {

        if (transform.position != target[current].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else
        {
            current = (current + 1) % target.Length;
            if (current == 0) {
                Debug.Log("Fin du jeu ");
                Text txt1 = GameObject.Find("numericalScore").GetComponent<Text>();
                txt1.text = "Vous avez fait un Score de " + txt1.text +" bien joué !";
                StartCoroutine("Win");
               // SceneManager.LoadScene("Menu");
            }
            
        }
    }

    IEnumerator Win() 
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Menu");
    }
}
