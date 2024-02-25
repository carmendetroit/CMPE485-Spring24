using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectPrefab; // Assign your prefab in the inspector
    public KeyCode spawnKey = KeyCode.Space; // The key to press for spawning the object

    void Update()
    {
        // Check if the spawn key is pressed
        if (Input.GetKeyDown(spawnKey))
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        // Instantiate the prefab at the specified position and rotation
        Instantiate(objectPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
