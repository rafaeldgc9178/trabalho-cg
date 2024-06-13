using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParedeInvisivel : MonoBehaviour
{
    public Light[] luzes; // Array para armazenar as luzes

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (Light luz in luzes)
            {
                luz.enabled = true; // Ativa cada luz no array
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (Light luz in luzes)
            {
                luz.enabled = false; // Desativa cada luz no array
            }
        }
    }
}


