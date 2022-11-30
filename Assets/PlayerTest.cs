using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    public static Action TriggerRed;
    public static Action<bool> TriggerBlue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red"))
        {
            TriggerRed?.Invoke();
        }

        if (other.CompareTag("Blue"))
        {
            TriggerBlue?.Invoke(true);
        }
    }

}
