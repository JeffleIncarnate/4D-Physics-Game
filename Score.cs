// Modules
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text Score_Text;

    // Update is called once per frame
    void Update()
    {
        Score_Text.text = player.position.y.ToString("0");
    }
}
