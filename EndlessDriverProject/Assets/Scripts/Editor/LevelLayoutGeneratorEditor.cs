using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LevelLayoutGenerator))]
public class LevelLayoutGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        LevelLayoutGenerator myTarget = (LevelLayoutGenerator) target;

        if (GUILayout.Button("Spawn Blocks"))
        {
            myTarget.SpawnBlocksEdit();
        }
        
        if (GUILayout.Button("Delete Blocks"))
        {
            myTarget.DeleteBlocksEdit();
        }

        if (GUILayout.Button("Respawn Blocks"))
        {
            myTarget.DeleteBlocksEdit();
            myTarget.SpawnBlocksEdit();
        }
    }
}
