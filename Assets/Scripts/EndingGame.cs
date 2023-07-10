using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingGame : MonoBehaviour
{
    public GameObject Ending;
    public GameObject Canvas;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Ending.SetActive(true);
            StartCoroutine("ending");
        }
    }
    IEnumerator ending()
    {
        yield return new WaitForSeconds(0.5f);
        Canvas.SetActive(true);
    }
}
