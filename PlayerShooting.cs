using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private int prefabsToSpawn = 100;
    [SerializeField] private float reloadTime = 0.3f;

    private List<GameObject> bullets = new List<GameObject>();

    private int currIndex;

    private float timer;

    private void Start()
    {
        for (int i = 0; i < prefabsToSpawn; i++)
        {           
            GameObject bullet = Instantiate(bulletPrefab);
            bullets.Add(bullet);
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space)&& timer >= reloadTime)
        {
            timer = 0;
            GameObject bullet = bullets[currIndex];
            bullet.transform.position = transform.position;
            bullet.SetActive(true);
            currIndex++;

            if (currIndex >= bullets.Count - 1)
            {
                currIndex = 0;
            }
        }
    }    
}
