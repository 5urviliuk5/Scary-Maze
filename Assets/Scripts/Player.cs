using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioSource deathSound;

    public GameObject retryButton;
    public GameObject scarypic;

    private void Update()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        GetComponent<Rigidbody2D>().MovePosition(mousePos);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Contains("Wall"))
        {
            deathSound.Play();
            retryButton.SetActive(true);
            scarypic.SetActive(true);
        }
    }
}
