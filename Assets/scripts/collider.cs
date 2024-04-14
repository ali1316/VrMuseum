using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    public GameObject spacial_panel;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            Debug.Log("gowa");
            spacial_panel.gameObject.SetActive(true);

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player")){
            Debug.Log("bara");
            spacial_panel.gameObject.SetActive(false);

        }
    }
}
