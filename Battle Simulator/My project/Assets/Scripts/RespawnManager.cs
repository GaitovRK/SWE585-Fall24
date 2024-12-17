using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public GameObject ragdollPrefab;
    public Transform spawnPoint;
    public float respawnTime = 2f;
    public float initialSpeed = 5f;
    public int numberOfRagdolls = 5;
    public int spawnDistance = 2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RespawnCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator RespawnCoroutine()
    {
        while (true)
        {
            // Wait for the specified time
            yield return new WaitForSeconds(respawnTime);

            // Respawn the object
            Respawn();
        }
    }

    private void Respawn()
    {

        for (int i = 0; i < numberOfRagdolls; i++)
        {
            Vector3 position = spawnPoint.position + new Vector3(i * spawnDistance, 0, 0);
            // Instantiate the ragdoll at the spawn point
            GameObject newRagdoll = Instantiate(ragdollPrefab, position, Quaternion.identity);

            // Get the Enemy script and start running
            Enemy enemy = newRagdoll.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.Initialize();
                enemy.StartRun(); 
            }
            else
            {
                Debug.LogError("Spawned ragdoll does not have an Enemy script!");
            }
        }
        
    }
}
