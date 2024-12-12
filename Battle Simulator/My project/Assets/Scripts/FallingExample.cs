using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingExample : MonoBehaviour
{

    [SerializeField] private List<Enemy> enemies;

    private void Awake()
    {
        foreach (var enemy in enemies)
        {
            enemy.Initialize();
            enemy.StartRun();
        }
    }
    
}
