using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    //public GameObject projectileBulletProto;
    public GameObject player;
    public float health = 5.0f;
    public int pointValue;

    public ParticleSystem DestroyedEffect;

    [Header("Audio")]
    public RandomPlayer HitPlayer;
    public AudioSource IdleSource;

    public bool Destroyed => m_Destroyed;

    bool m_Destroyed = false;
    float m_CurrentHealth;

    public EnemySpawn spawnEnemy;
 
    public AudioSource myAudio;
    public AudioClip sound1;
    
    public float timeToWaitForMessage;

    void Awake()
    {
        Helpers.RecursiveLayerChange(transform, LayerMask.NameToLayer("Target"));
    }

    void Start()
    {
        //if(DestroyedEffect)
        // PoolSystem.Instance.InitPool(DestroyedEffect, 16);
        spawnEnemy = GameObject.Find("Respawn Point and Target").GetComponent<EnemySpawn>();
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
        if(Input.GetKeyDown(KeyCode.L))
        {
            Got(1.0f);
        }
    }

    public void Got(float damage)
    {
        Debug.Log(damage.ToString() + " DAMAGE");

        m_CurrentHealth -= damage;

        if (m_CurrentHealth > 0)
            return;

        Vector3 position = transform.position;

        spawnEnemy.RespawnEnemy();

        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider projectile)
    {
        if (projectile.gameObject.CompareTag("Bullet") && player.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Attack1"))
        {
            Got(1.0f);
            //HitPlayer.PlayRandom();
            //Debug.Log("Enemy is Hit");
        }       
    }    
}
