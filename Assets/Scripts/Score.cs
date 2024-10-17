using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerPosition;

    public int distance;
    public TextMeshProUGUI scoreText;
    
    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerPosition.position.z.ToString("0");
        
    }
}
