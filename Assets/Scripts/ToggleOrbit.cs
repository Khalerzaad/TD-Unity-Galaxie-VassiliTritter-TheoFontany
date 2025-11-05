using UnityEngine;

public class ToggleOrbit : MonoBehaviour
{
    private Orbits orbit;

    private void Awake()
    {
        orbit = GetComponent<Orbits>();
    }

    // Update is called once per frame
    void Update()
    {
        if (orbit == null) return;
        // Si on appuie espace
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // inverse le statut de orbit
            orbit.enabled = !orbit.enabled;
        }
    }
}
