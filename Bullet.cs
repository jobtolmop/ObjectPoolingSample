using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int speed = 10;

    private void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }


}
