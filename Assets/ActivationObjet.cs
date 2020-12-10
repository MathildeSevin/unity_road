using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationObjet : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject objetFixe;
    public GameObject objetMobile;
    public GameObject objetMixte;

    void Start()
    {
        objetFixe.SetActive(false);
        objetMobile.SetActive(false);
        objetMixte.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        objetFixe.SetActive(true);
        objetMobile.SetActive(true);
        objetMixte.SetActive(true);
    }
}
