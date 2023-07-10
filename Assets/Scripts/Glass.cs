using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Glass : MonoBehaviour
{
    public Transform player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player") && player.transform.localScale.x >= 2f && player.transform.localScale.y >= 2f)
        {
            StartCoroutine("GlassBreak");
        }
    }

    IEnumerator GlassBreak()
    {
        yield return new WaitForSeconds(0.6f);
        this.gameObject.SetActive(false);
    }
}
