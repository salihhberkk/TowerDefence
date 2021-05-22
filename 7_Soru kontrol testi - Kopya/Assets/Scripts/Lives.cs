using UnityEngine.UI;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public Text livesText;
    // Update is called once per frame
    void Update()
    {
        livesText.text = "Kalan Can:" + PlayerStats.Lives.ToString() ;
    }
}
