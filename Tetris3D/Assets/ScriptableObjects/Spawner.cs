using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[InlineEditor]
[CreateAssetMenu(fileName = "Spawner", menuName = "Gameplay/Spawner")]
public class Spawner : ScriptableObject
{
    public GameObject[] pieces;
    GameObject LastPiece;

    public void SpawnNewPiece()
    {
        GameObject newPiece = pieces[Random.Range(0, pieces.Length)];
        while(newPiece == LastPiece)
        {
            newPiece = pieces[Random.Range(0, pieces.Length)];
        }
        LastPiece = newPiece;
        Instantiate(newPiece);
    }
}
