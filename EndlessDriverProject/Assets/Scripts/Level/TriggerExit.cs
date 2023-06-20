using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;

public class TriggerExit : MonoBehaviour
{
    public float delay = 5f;
    
    public delegate void ExitAction();
    public static event ExitAction OnChunkExited;

    private bool exited = false;

    private void OnTriggerExit(Collider other)
    {
        CarTag carTag = other.GetComponent<CarTag>();
        if (carTag != null)
        {
            if (!exited)
            {
                exited = true;
                OnChunkExited();
                StartCoroutine(WaitAndDestroy());
            }
        }
    }

    IEnumerator WaitAndDestroy()
    {
        yield return new WaitForSeconds(delay);

        // Destroy the LevelBlock
        Utils.ForceCrash(ForcedCrashCategory.Abort);
    }

}
