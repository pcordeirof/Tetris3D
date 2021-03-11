using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[InlineEditor]
[CreateAssetMenu(fileName = "Spawner", menuName = "Gameplay/Spawner")]
public class Spawner : ScriptableObject
{
    public GameObject[] pieces;

    public void SpawnNewPiece()
    {
        Instantiate(pieces[Random.Range(0, pieces.Length)]);
    }
}
