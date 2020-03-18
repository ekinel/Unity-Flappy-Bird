using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columns : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.left * 2 * Time.deltaTime);
        if (transform.position.x < -5.3f)
        {
            Destroy(this.gameObject);
        }
    }
}
