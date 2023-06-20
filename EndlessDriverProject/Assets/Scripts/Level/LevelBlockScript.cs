using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBlockScript : MonoBehaviour
{
    [Header("Obstacles")]
    public GameObject[] obstacles;
    public int spawnProbability;

    [Header("Spawn Points")] 
    public Transform[] spawnPoints;
    
    void Awake()
    {
        SpawnObstacles();
    }

    public void SpawnObstacles()
    {
        if (obstacles.Length == 0 || spawnPoints.Length == 0)
            return;

        foreach (var point in spawnPoints)
        {
            int randomNumber = Random.Range(0, 100);

            if (randomNumber < spawnProbability)
            {
                int randomObstacleId = Random.Range(0, obstacles.Length);

                var tempObject = Instantiate(obstacles[randomObstacleId], this.transform);
                tempObject.transform.position = point.position;
                tempObject.transform.localPosition = new Vector3(tempObject.transform.localPosition.x + Random.Range(-0.5f, 0.5f), tempObject.transform.localPosition.y, tempObject.transform.localPosition.z + Random.Range(-0.5f, 0.5f));
                tempObject.transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
            }
        }
    }


}
