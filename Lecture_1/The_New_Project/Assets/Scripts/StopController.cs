using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopController : MonoBehaviour
{
   //Karakterin trigger objesine girdiği zaman durmasını ve idle animasyonuna geçmesini kontrol ediyoruz
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            other.GetComponent<Movement>().speed = 0;
            other.GetComponent<Animator>().SetBool("isRun", false);
        }
    }
}
