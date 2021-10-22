using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSound : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject sound;
    public GameObject backSound;
=======
>>>>>>> Hector
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
<<<<<<< HEAD
            sound.SetActive(true);
            backSound.SetActive(false);
=======
            FindObjectOfType<AudioManager>().Switch();
>>>>>>> Hector
            Destroy(gameObject);
        }
    }
}
