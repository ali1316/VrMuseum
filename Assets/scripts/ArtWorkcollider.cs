using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtWorkcollider : MonoBehaviour
{
    public GameObject spatial_panel;
    private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                spatial_panel.gameObject.SetActive(true);
                // Here, you can trigger the display of artwork information UI canvas.
            }
        }
    private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                spatial_panel.gameObject.SetActive(false);
                // Here, you can trigger the display of artwork information UI canvas.
            }
        }
}
