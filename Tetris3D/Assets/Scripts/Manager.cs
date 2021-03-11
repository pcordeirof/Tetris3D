using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Spawner spawner;
    public GridSettings gridSettings;
    void Start()
    {
        gridSettings.InstatiateGrid();
        spawner.SpawnNewPiece();
    }

}
