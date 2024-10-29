using UnityEngine;

public class PlanetMovement : MonoBehaviour
{
    [System.Serializable]
    public class Planet
    {
        public string name;
        public float orbitRadius; // Distance from the sun
        public float orbitSpeed;   // Speed of orbit in degrees per second
        public Transform planetTransform;
    }

    public Transform sun;
    public Planet[] planets; // Array of planets

    private void Update()
    {
        foreach (Planet planet in planets)
        {
            MovePlanet(planet);
        }
    }

    private void MovePlanet(Planet planet)
    {
        // Calculate the angle of the planet in its orbit
        float angle = Time.time * planet.orbitSpeed;

        // Convert angle to radians
        float radians = angle * Mathf.Deg2Rad;

        // Calculate the new position based on orbit radius and angle
        Vector3 newPosition = new Vector3(
            Mathf.Cos(radians) * planet.orbitRadius,
            0f, // Keep planets on the same plane (Y-axis)
            Mathf.Sin(radians) * planet.orbitRadius
        );

        // Update the planet's position relative to the sun
        planet.planetTransform.position = sun.position + newPosition;
    }
}

