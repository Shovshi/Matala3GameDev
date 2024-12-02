﻿using UnityEngine;

/**
 * This component spawns the given laser-prefab whenever the player clicks a given key.
 * It also updates the "pointsToAdd" field of the new laser.
 */
public class LaserShooter : ClickSpawner
{
    [SerializeField]
    [Tooltip("How many points to add to the shooter, if the laser hits its target")]
    int pointsToAdd = 1;

    [SerializeField]
    [Tooltip("The tag of the target objects that the laser can hit.")]
    string targetTag = "Enemy";

    protected override GameObject spawnObject()
    {
        GameObject newObject = base.spawnObject(); // יצירת הלייזר

        // חיבור ScoreAdder ללייזר
        ScoreAdder scoreAdder = newObject.GetComponent<ScoreAdder>();
        if (scoreAdder != null)
        {
            scoreAdder.SetPointsToAdd(pointsToAdd);
            scoreAdder.triggeringTag = targetTag;
        }

        return newObject;
    }
}
