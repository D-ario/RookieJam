using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEAM7_cameraMoov : MonoBehaviour
{
    public int mouvValue = 1;
    public bool isDebited = false;

    private bool actif = true;


    void Update() {
        if ((Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) ||
             Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow)) 
             && actif == true)
        {                 
            StartCoroutine(moovLess());
            isDebited = false;
            
        }
    }

    IEnumerator moovLess()
    {
        actif = false;
        TEAM7_mouvement.instance.ChangeScore(mouvValue, isDebited); 
        yield return new WaitForSeconds(1);
        actif = true;
    }
}
