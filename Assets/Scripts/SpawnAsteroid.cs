using UnityEngine;

public class SpawnAsteroid : MonoBehaviour
{
    [SerializeField] private GameObject spawnedObject;
    [SerializeField] private Transform pivot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && spawnedObject != null)
        {
            // Create object to spawn in game
            GameObject asteroid = Instantiate(spawnedObject);
            asteroid.transform.position = Vector3.zero;
            // randomly modifies offset from pivot in x axis
            asteroid.transform.GetChild(0).transform.localPosition = new Vector3(Random.Range(0f, 10f), 0, 0);
            // randomly modifies rotation values on pivot in y and z axis
            asteroid.transform.localRotation = Quaternion.Euler(new Vector3(0, Random.Range(0f, 10f), Random.Range(0f, 10f)));
            asteroid.GetComponent<Orbits>().SetSelfRotationSpeed(Random.Range(30f, 60f));
            asteroid.GetComponent<Orbits>().SetAngularSpeed(Random.Range(2f, 10f));
            asteroid.GetComponent<Orbits>().SetPivot(pivot);
        }
    }
}
