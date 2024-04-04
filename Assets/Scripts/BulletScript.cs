using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletScript : MonoBehaviour
{
    public int enemyCount;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Agent")
        {
            Destroy(collision.gameObject);

        }
        Destroy(gameObject);
        Debug.Log("hit");
    }
}
