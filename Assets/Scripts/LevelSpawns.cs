using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawns : MonoBehaviour
{

    [System.Serializable]
    public class SpawnPoints
    {
        public string name;
        public Vector2 spawnPoint;
    }

    public SpawnPoints[] spawns;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public Vector2 getSpawnPoint(string name)
    {
        for (int i = 0; i < spawns.Length; i++)
        {
            if (spawns[i].name == name)
            {
                return spawns[i].spawnPoint;
            }
        }

        return spawns[0].spawnPoint;
    }


    void OnDrawGizmos()
    {
        if (spawns.Length != 0)
        {
            Gizmos.color = Color.cyan;
            float size = .3f;

            for (int i = 0; i < spawns.Length; i++)
            {
                Vector3 globalWaypointPos = new Vector3(spawns[i].spawnPoint.x, spawns[i].spawnPoint.y, 0);
                Gizmos.DrawLine(globalWaypointPos - Vector3.up * size, globalWaypointPos + Vector3.up * size);
                Gizmos.DrawLine(globalWaypointPos - Vector3.left * size, globalWaypointPos + Vector3.left * size);

                //UnityEditor.Handles.color = Color.cyan;
                //UnityEditor.Handles.Label(globalWaypointPos + Vector3.up * (size * 3), spawns[i].name);
            }
        }
    }


}
