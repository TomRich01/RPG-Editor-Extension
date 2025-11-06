using UnityEngine;

public class WorldClock : MonoBehaviour
{
    // Time scale: 1 real second = timeScale in-game seconds
    public float timeScale = 20.0f; // Skyrim-like: 20 in-game seconds per real second
    public float secondsPerInGameDay = 86400.0f; // 24 hours * 60 minutes * 60 seconds

    // Current in-game time
    private float currentTimeInSeconds = 0.0f; // Tracks total seconds since day start
    private int currentDay = 1; // Tracks in-game days

    // Properties to access time components
    public int Hours => Mathf.FloorToInt(currentTimeInSeconds / 3600.0f) % 24; // Hours in 24-hour format
    public int Minutes => Mathf.FloorToInt((currentTimeInSeconds % 3600.0f) / 60.0f); // Minutes
    public int Days => currentDay; // Current day

    // Optional: Starting time (e.g., start at 7:00 AM)
    public float startHour = 7.0f; // Start at 7:00 AM

    void Start()
    {
        // Initialize time to startHour (convert hours to seconds)
        currentTimeInSeconds = startHour * 3600.0f;
    }

    void Update()
    {
        // Increment time based on real time and time scale
        currentTimeInSeconds += Time.deltaTime * timeScale;

        // Check if a full day has passed (24 in-game hours)
        if (currentTimeInSeconds >= secondsPerInGameDay)
        {
            currentTimeInSeconds -= secondsPerInGameDay; // Reset to start of next day
            currentDay++; // Increment day counter
        }

        // Optional: Log time for debugging
        Debug.Log($"Day {Days}, Time: {Hours:D2}:{Minutes:D2}");
    }

    // Helper method to get formatted time as string
    public string GetFormattedTime()
    {
        string period = Hours < 12 ? "AM" : "PM";
        int displayHours = Hours % 12 == 0 ? 12 : Hours % 12; // Convert to 12-hour format
        return $"Day {Days}, {displayHours:D2}:{Minutes:D2} {period}";
    }
}
