using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

using Vector3 = UnityEngine.Vector3;

public class Target : MonoBehaviour
{
    //public GameObject projectileBulletProto;
    public GameObject player;

    public float health = 100.0f;

    public int pointValue;

    public float playerDamage;

    public float conversionNormal;

    public ParticleSystem DestroyedEffect;

    [Header("Audio")]
    public RandomPlayer HitPlayer;

    public AudioSource IdleSource;

    public bool Destroyed => m_Destroyed;

    bool m_Destroyed = false;

    float m_CurrentHealth;

    public GameObject healthPercentageBar1;

    public GameObject healthPercentageBar2;

    public EnemySpawn spawnEnemy;

    public AudioSource myAudio;

    public AudioClip sound1;

    public float timeToWaitForMessage;

    void Awake()
    {
        Helpers
            .RecursiveLayerChange(transform, LayerMask.NameToLayer("Target"));
    }

    void Start()
    {
        health = 100.0f;
        playerDamage = 10.0f;

        //if(DestroyedEffect)
        // PoolSystem.Instance.InitPool(DestroyedEffect, 16);
        spawnEnemy =
            GameObject
                .Find("Respawn Point and Target")
                .GetComponent<EnemySpawn>();
        m_CurrentHealth = health;
        if (IdleSource != null)
            IdleSource.time = Random.Range(0.0f, IdleSource.clip.length);

        myAudio = gameObject.AddComponent<AudioSource>();
        myAudio.playOnAwake = false;
        myAudio.clip = sound1;
        player = GameObject.Find("Knight");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Got (playerDamage);
        }
    }

    public void Got(float damage)
    {
        Debug.Log(damage.ToString() + " DAMAGE");

        m_CurrentHealth -= damage;

        /*
            Health from 0 - 100 is converted to range 0.0 - 0.94 for scale of health bar cubes on enemies
            float aValue;
            float normal = Mathf.InverseLerp(aLow, aHigh, value);
            float bValue = Mathf.Lerp(bLow, bHigh, normal);
        */
        conversionNormal = Mathf.InverseLerp(0f, 100f, m_CurrentHealth);
        healthPercentageBar1.transform.localScale =
            new Vector3(Mathf.Lerp(0.0f, 0.94f, conversionNormal),
                healthPercentageBar1.transform.localScale.y,
                healthPercentageBar1.transform.localScale.z);
        healthPercentageBar2.transform.localScale =
            new Vector3(Mathf.Lerp(0.0f, 0.94f, conversionNormal),
                healthPercentageBar2.transform.localScale.y,
                healthPercentageBar2.transform.localScale.z);

        if (m_CurrentHealth > 0) return;

        Vector3 position = transform.position;

        spawnEnemy.RespawnEnemy();

        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider projectile)
    {
        if (
            projectile.gameObject.CompareTag("Bullet") &&
            player
                .GetComponent<Animator>()
                .GetCurrentAnimatorStateInfo(0)
                .IsName("Attack1")
        )
        {
            Got (playerDamage);
            //HitPlayer.PlayRandom();
            //Debug.Log("Enemy is Hit");
        }
    }
}
