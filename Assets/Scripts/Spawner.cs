using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawner : MonoBehaviour
{


    public GameObject[] hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public List<GameObject> spawned = new List<GameObject>();
    public int spawnedQty;
    public void Remove(GameObject g)
        
    {

        if (spawned.Contains(g))
        {

            spawned.Remove(g);
            if (spawnedQty >= hazardCount)
            {

                if (spawned.Count == 0)
                {

                    NextLevel();

                }

            }

        }

    }
    void NextLevel()
    {

        GameManager.manager.level++;
        if (GameManager.manager.level >= GameManager.manager.maxlevel) return;
        spawnedQty = 0;
        StartCoroutine(SpawnWaves(GameManager.manager.level));


    }

    void Start()
    {
        StartCoroutine(SpawnWaves(0));
    }

    IEnumerator SpawnWaves(int level)
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                GameObject g= Instantiate(hazard[level], spawnPosition, spawnRotation);
                spawnedQty++;
                spawned.Add(g);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }

    }







}


