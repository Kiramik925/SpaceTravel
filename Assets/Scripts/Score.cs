using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int ring = 0;

    private void Start()
    {
        scoreText.text = $"Score: {ring}";
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ring"))
        {
            ring++;
            Destroy(other.gameObject);
            scoreText.text = $"Score: {ring}"; 
        }
    }
}
