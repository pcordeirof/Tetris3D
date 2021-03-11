using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[InlineEditor]
[CreateAssetMenu(fileName = "GridSettings", menuName = "Configurations/GridSettings")]
public class GridSettings : ScriptableObject
{
    public FloatVariable Width;
    public FloatVariable Height;

    public Transform[,] Grid;

    
}
