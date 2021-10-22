using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage;
    public float speed;
    public string particleName;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            ParticleManager.instance.StartParticle(particleName, transform.position);
            collision.GetComponent<PlayerController>().health -= damage;
            Debug.Log(collision.GetComponent<PlayerController>().health);
            Destroy(gameObject);
        }
    }
}
