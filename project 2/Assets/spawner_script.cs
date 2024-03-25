using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class spawner_script : MonoBehaviour
{
    public GameObject coinPrefab;

    void Start()
    {
        StartCoroutine(SpawnCoinWithDelay());
    }

    IEnumerator SpawnCoinWithDelay()
    {
        while (true) // Repeat indefinitely or use your own condition
        {
            int x_rnd = UnityEngine.Random.Range(-50, 51);
            int y_rnd = UnityEngine.Random.Range(2, 21);
            int z_rnd = UnityEngine.Random.Range(-50, 51);
            Vector3 position = new Vector3(x_rnd, y_rnd, z_rnd);
            GameObject newObject = Instantiate(coinPrefab, position, Quaternion.identity);
            CollisionHandler collisionHandler = newObject.AddComponent<CollisionHandler>();

         // Assign the reference of the instantiated object to the CollisionHandler script
            collisionHandler.objectToDestroy = newObject;

            int randomNumber = UnityEngine.Random.Range(500, 3001);
            yield return new WaitForSeconds(randomNumber / 1000f); // Wait for the specified time
        }
    }

}
