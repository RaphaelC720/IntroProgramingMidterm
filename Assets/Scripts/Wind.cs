using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Wind : MonoBehaviour
{
    public PlayerScript PS;
    public EnemySpawner ES;
    public AreaEffector2D wind;

    void Start()
    {
        wind.forceAngle = 0;
        wind.forceMagnitude = 0;
    }

    void Update()
    {
        if (PS.Score >= 50)
        {
            wind.forceMagnitude = 10;
            wind.forceAngle = 180;
        }
        else if (PS.Score >= 35)
        {
            wind.forceMagnitude = 5;
            ES.NextSpawn = 0.25f;

        }
        else if (PS.Score >= 25)
        {
            wind.forceMagnitude = 15;
        }
        else if(PS.Score >= 15)
        {
            wind.forceMagnitude = 10;
        }
        else if(PS.Score >= 5)
        {
        wind.forceMagnitude = 5;
        }
    }
}
