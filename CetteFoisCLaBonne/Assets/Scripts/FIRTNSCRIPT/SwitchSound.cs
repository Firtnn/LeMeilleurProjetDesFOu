using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSound : MonoBehaviour
{
    public GameObject sound;
    public GameObject backSound;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            sound.SetActive(true);
            backSound.SetActive(false);
            Destroy(gameObject);
        }
    }
}
