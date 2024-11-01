using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // The number of seconds it takes for the light to complete a full rotation (simulate one day)
    [Tooltip("Seconds for a full day to pass")]
    public float secondsPerDay = 120f; // Default is set to 120 seconds (2 minutes)

    // Update is called once per frame
    void Update()
    {
        // Calculate the amount of rotation for this frame
        float rotationAmount = (360f / secondsPerDay) * Time.deltaTime;

        // Rotate the light around the x-axis
        transform.Rotate(rotationAmount, 0f, 0f);
    }
}