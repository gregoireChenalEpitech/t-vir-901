using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicbleReactive : MonoBehaviour
{
    internal void JeSuisTouche()
    {
        StartCoroutine(JeMeurt());

    }

    private IEnumerator JeMeurt() {
        transform.Rotate(-90, 0, 0);
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
