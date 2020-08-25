using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    public FallingItem target;

    [Tooltip("Spawn \"spawnFrequency\" targets in min")]
    [Range(0, 180)]
    public float spawnFrequency = 2;

    [Range(0f, 5f)]
    public float scale = 1f;

    private float cameraSize;

    protected int spawnerLevel;
    public abstract void LevelUp();

    void Start()
    {
        cameraSize = Camera.main.orthographicSize;  
    }

    void FixedUpdate()
    {
        float randomTicket = Random.Range(0f, 1f);
        if (randomTicket >= 0f && randomTicket < spawnFrequency / 3000) // 3000 calls in min
        {
            FallingItem clone = Instantiate(target);
            clone.transform.localPosition = new Vector2(Random.Range(-11f, 11f), cameraSize + 1);
            clone.transform.localScale *= scale;
        }
    }
}
