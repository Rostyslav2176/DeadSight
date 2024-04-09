using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletScript : MonoBehaviour
{
    public int enemyCount;
    KillCount killCountScript;

    private void Start()
    {
        killCountScript = GameObject.Find("KCO").GetComponent<KillCount>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Agent")
        {
            Destroy(collision.gameObject);
            killCountScript.AddKill();

        }
        Destroy(gameObject);
        Debug.Log("hit");
    }
}
