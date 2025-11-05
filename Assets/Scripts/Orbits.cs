using UnityEngine;

public class Orbits : MonoBehaviour
{
    // Centre de l'orbite
    [SerializeField] private Transform pivot;
    // Vitesse angulaire (degré/seconde)
    [SerializeField] private float angularSpeed = 20f;
    // Rotation propre de la planète en degrés/secondes
    [SerializeField] private float selfRotationSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        if (pivot != null)
        {
            // orbite autour du pivot (axe Y)
            transform.RotateAround(pivot.position, Vector3.up, angularSpeed * Time.deltaTime);
        }

        // rotation sur soi-même (axe Y)
        transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime, Space.Self);

    }
    public void SetSelfRotationSpeed(float inputRotationSpeed)
    { 
        selfRotationSpeed = inputRotationSpeed; 
    }
    public void SetAngularSpeed(float inputAngularSpeed)
    {
        angularSpeed = inputAngularSpeed;
    }
}
