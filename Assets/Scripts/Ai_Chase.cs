using UnityEngine;

public class Ai_Chase : MonoBehaviour
{
    public GameObject player;
    public GameObject uýPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.SetActive(false);
            Time.timeScale= 0f;
            uýPanel.SetActive(true);
        }
    }
}
