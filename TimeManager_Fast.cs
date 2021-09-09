// Modules
using UnityEngine;

// Unity Class
public class TimeManager_Fast : MonoBehaviour
{
    // Variables
    public float fastUpFactor = 5f;
    public float fastUpLength = 2f;

    // Update
    public void Update()
    {
        Time.timeScale -= (1f / fastUpLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

    // Fast Method
    public void doFastMotion()
    {
        Time.timeScale = fastUpFactor;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }

}
