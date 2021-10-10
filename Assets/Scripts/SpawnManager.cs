﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float minX, maxX, minY, maxY;
    public GameObject kotakPrefabs;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {

        int objectCount = 10;
        for (int i = 0; i < objectCount; i++)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);

            GameObject kotak = Instantiate(kotakPrefabs, new Vector2(randomX, randomY), Quaternion.identity) as GameObject;
            kotak.transform.SetParent(GameObject.FindGameObjectWithTag("Spawn").transform, false);
        }
        StartCoroutine(SpawnKotak());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnKotak()
    {
        if (transform.childCount < 10)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);

            GameObject kotak = Instantiate(kotakPrefabs, new Vector2(randomX, randomY), Quaternion.identity) as GameObject;
            kotak.transform.SetParent(GameObject.FindGameObjectWithTag("Spawn").transform, false);
        }
        yield return new WaitForSeconds(3);
        StartCoroutine(SpawnKotak());
    }
}
