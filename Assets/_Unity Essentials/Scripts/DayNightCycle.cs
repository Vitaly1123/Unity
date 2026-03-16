using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Налаштування часу")]
    [Tooltip("Скільки реальних секунд має тривати один повний ігровий день (360 градусів)")]
    public float dayDurationInSeconds = 120f;

    void Update()
    {
        if (dayDurationInSeconds <= 0f) return;

        float degreesPerSecond = 360f / dayDurationInSeconds;

        transform.Rotate(Vector3.right, degreesPerSecond * Time.deltaTime);
    }
}