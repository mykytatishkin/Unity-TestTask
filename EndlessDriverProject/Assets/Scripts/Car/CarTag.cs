using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;

public class CarTag : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        // TODO: Insert collision code :)
        
        // One example for you, please follow this example making other collisions
        if (collision.gameObject.CompareTag("TeamTrees"))
        {
            Debug.LogError("WHy u hit treees");
            Utils.ForceCrash(ForcedCrashCategory.Abort);
        }
        // Do not delete the section below - this is to guide you
        else if (collision.gameObject.CompareTag("Untagged"))
        {
            Debug.LogError("Undefined Object hit - please set the Tag");
        }
    }

}
