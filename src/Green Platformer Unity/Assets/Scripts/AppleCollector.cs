using UnityEngine;
using UnityExtensions.ScriptableTools.Variables;

public class AppleCollector : MonoBehaviour
{
    public FloatVariable playerAppleScore;
    public int appleScore = 1;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerAppleScore.Value += appleScore;
            Destroy(gameObject);
        }
    }
}
