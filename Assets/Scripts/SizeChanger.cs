using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    public bool isSmaller;
    public bool isBreakable = false;
    public Transform player;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector2 smallScale = player.localScale * 0.5f;
        Vector2 bigScale = player.localScale * 2f;

        if (collision.CompareTag("Player") && isSmaller)
        {
            player.localScale = smallScale;
            this.gameObject.SetActive(false);
        }
        if (collision.CompareTag("Player") && isSmaller == false)
        {
            player.localScale = bigScale;
            this.gameObject.SetActive(false);
            isBreakable = true;
        }
    }
}
