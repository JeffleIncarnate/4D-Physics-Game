// Modules
using UnityEngine;

// Unity Class
public class TimeManager : MonoBehaviour
{
    // Variables
    public float slowDownFactor = 0.05f;
    public float slowDownLength = 2f;

    // Update Method
    public void Update()
    {
        Time.timeScale += (1f / slowDownLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

    // Slow Method
    public void doSlowMotion()
    {
        Time.timeScale = slowDownFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}
