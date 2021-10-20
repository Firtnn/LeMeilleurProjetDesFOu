using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField] private GameObject background = default;
    [SerializeField] private Transform player = default;
    [SerializeField] private float spawnX = 0.0f;
    [SerializeField] private float length = 40f;
    [SerializeField] private int amountOfTileOnScreen = 3;
    [SerializeField] private float speed = -7;


    private float offset = 25f;// si besoin pour le spawn
    private List<GameObject> activeTiles;
    private Vector3 velocity;

    private void Start()
    {
        velocity = new Vector3(speed, 0f);
        activeTiles = new List<GameObject>();
        for (int i = 0; i < amountOfTileOnScreen; i++)
        {
            FirstSpawnTile(i);
        }

        //events : 
    }

    private void Update()
    {
        for (int i = 0; i < activeTiles.Count; i++)
        {
            activeTiles[i].transform.position += velocity * Time.deltaTime;
        }
        if (activeTiles[0].transform.position.x < player.position.x - length)
        {
            DeleteTile();
            SpawnTile(0);
        }
    }

    // avec des event ça peut tjr etre utile
    public void StopMoving()
    {
        velocity = Vector3.zero;
    }
    public void startMoving()
    {
        velocity = new Vector3(-10f, 0f);
    }

    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }

    //on fait spawn 3 background de base
    private void FirstSpawnTile(int prefabIndex)
    {
        GameObject go = Instantiate(background);

        go.transform.SetParent(transform);
        go.transform.position = Vector3.right * spawnX;
        spawnX += length;
        activeTiles.Add(go);
    }
    //puis on update le BG
    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go = Instantiate(background);
        go.transform.SetParent(transform);
        go.transform.position = Vector3.right * (activeTiles[1].transform.position.x + length);
        activeTiles.Add(go);
    }

    private void OnDestroy()
    {
    }
}

