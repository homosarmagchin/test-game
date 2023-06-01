using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    bool dead = false;
    [SerializeField] AudioSource deathSong;
    private void Update()
    {
        if (transform.position.y < -2f && !dead)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMove>().enabled = false;
            Die();
        }
    }
    void OnCollisionEnter(UnityEngine.Collision col)
    {
        if (col.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }
    }
    void Die()
    {
        // GetComponent<MeshCollider>().enabled = false;
        Invoke(nameof(ReloadLevel), 1.3f);
        dead = true;
        deathSong.Play();
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
