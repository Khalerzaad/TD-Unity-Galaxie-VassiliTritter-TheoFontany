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
            // la partie empty de la planète se place sur le pivot et rotate sur l'axe Y
            transform.position = pivot.position;
            transform.Rotate(Vector3.up, angularSpeed * Time.deltaTime, Space.Self);
        }

        // rotation sur soi-même (axe Y)
        transform.GetChild(0).transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime, Space.Self);

    }
    public void SetSelfRotationSpeed(float inputRotationSpeed)
    { 
        selfRotationSpeed = inputRotationSpeed; 
    }
    public void SetAngularSpeed(float inputAngularSpeed)
    {
        angularSpeed = inputAngularSpeed;
    }
    public void SetPivot(Transform inputPivot)
    {
        pivot = inputPivot;
    }
}
