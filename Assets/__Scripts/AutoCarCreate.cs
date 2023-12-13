using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class AutoCarCreate : MonoBehaviour
{
    [NonSerialized]
    public bool isEnemy = false;

    public GameObject car;
    public float time = 5f, maxRandom = 7f, minRandom = 3f;
    private int count = 0;

    private void Start()
    {
        if (gameObject.CompareTag("House"))
        { time = 10f; count = 20; }
        else if (gameObject.CompareTag("Industry"))
        { time = 3f; count = 3; maxRandom = 15; minRandom = 5f; }    
        else
        { time = 5f; count = 5; }
        StartCoroutine(SpawnCar());
    }

    IEnumerator SpawnCar()
    {
        for (int i = 1; i <= count; i++)
        {
            yield return new WaitForSeconds(time);
            Vector3 pos = new Vector3(
                transform.GetChild(0).position.x + UnityEngine.Random.Range(minRandom, maxRandom),
                transform.GetChild(0).position.y,
                transform.GetChild(0).position.z + UnityEngine.Random.Range(minRandom, maxRandom));
            GameObject spawn = Instantiate(car, pos, Quaternion.identity);

            if (isEnemy)
                spawn.tag = "Enemy";
        }
    }
}
