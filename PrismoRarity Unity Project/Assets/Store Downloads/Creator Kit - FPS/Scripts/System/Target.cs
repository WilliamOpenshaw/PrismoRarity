using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    //public GameObject projectileBulletProto;

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
    //public firePlayerGun gunShapeChange;
    public GameObject memeHolder;
    public GameObject gunHolder;

    //public AssignFirstMeme chooseMeme;

    public GameObject stocksStolenMessage;
    public GameObject stocksStolenMessage2;
    public GameObject stocksStolenMessage3;

    public AudioSource myAudio;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;
    public AudioClip sound6;
    public AudioClip sound7;
    public AudioClip sound8;
    public AudioClip sound9;
    public AudioClip sound10;
    public AudioClip sound11;
    public AudioClip sound12;
    public AudioClip sound13;
    public AudioClip sound14;
    public AudioClip sound15;
    public AudioClip sound16;
    public AudioClip sound17;
    public AudioClip sound18;
    public AudioClip sound19;
    public AudioClip sound20;
    public AudioClip sound21;
    public AudioClip sound22;
    public AudioClip sound23;
    public AudioClip sound24;
    public AudioClip sound25;
    public AudioClip sound26;
    public AudioClip sound27;
    public AudioClip sound28;
    public AudioClip sound29;
    public AudioClip sound30;
    public AudioClip sound31;
    public AudioClip sound32;
    public AudioClip sound33;
    public AudioClip sound34;
    public AudioClip sound35;
    public AudioClip sound36;
    public AudioClip sound37;
    public AudioClip sound38;

    public AudioClip sound39;

    public AudioClip sound40;

    public AudioClip sound41;

    public int playTalkNum;
    //public memeMarketController memeData;

    public int numberOfSTocksToSteal;
    public int currNumStocksToDelete;
    public int stocksStolenFromSpecificMeme;
    public float timeToWaitForMessage;
    void Awake()
    {
        Helpers.RecursiveLayerChange(transform, LayerMask.NameToLayer("Target"));
    }

    void Start()
    {
        //if(DestroyedEffect)
        // PoolSystem.Instance.InitPool(DestroyedEffect, 16);

        m_CurrentHealth = health;
        if (IdleSource != null)
            IdleSource.time = Random.Range(0.0f, IdleSource.clip.length);

        myAudio = gameObject.AddComponent<AudioSource>();
        myAudio.playOnAwake = false;
        myAudio.clip = sound1;
        numberOfSTocksToSteal = 0;
        currNumStocksToDelete = 0;
        stocksStolenFromSpecificMeme = 0;
        timeToWaitForMessage = -1.0f;
        stocksStolenMessage.SetActive(false);
        stocksStolenMessage2.SetActive(false);
        stocksStolenMessage3.SetActive(false);
    }

    public void Got(float damage)
    {
        m_CurrentHealth -= damage;

        //if(HitPlayer != null)
        //    HitPlayer.PlayRandom();

        if (m_CurrentHealth > 0)
            return;

        Vector3 position = transform.position;

        //the audiosource of the target will get destroyed, so we need to grab a world one and play the clip through it
        //if (HitPlayer != null)
        //{
        //    var source = WorldAudioPool.GetWorldSFXSource();
        //   source.transform.position = position;
        //    source.pitch = HitPlayer.source.pitch;
        //   source.PlayOneShot(HitPlayer.GetRandomClip());
        // }

        //if (DestroyedEffect != null)
        //{
        //    var effect = PoolSystem.Instance.GetInstance<ParticleSystem>(DestroyedEffect);
        //    effect.time = 0.0f;
        //    effect.Play();
        //    effect.transform.position = position;
        //}

        //m_Destroyed = true;

        //gunShapeChange.RandomizeWeaponAndProjectile();
        //HitPlayer.PlayRandom();
        //gameObject.SetActive(false);
        spawnEnemy.RespawnEnemy();

        GameObject memeInstance = Instantiate(memeHolder, gameObject.transform.position + Vector3.back, transform.rotation) as GameObject;
        memeInstance.tag = "Meme";
        //memeInstance.GetComponent<AssignFirstMeme>().ChooseFirstMemeFunction();
        GameObject gunChangeInstance = Instantiate(gunHolder, gameObject.transform.position + Vector3.forward, transform.rotation) as GameObject;
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider projectile)
    {
        if (projectile.gameObject.CompareTag("Bullet"))
        {
            Got(5.0f);
            HitPlayer.PlayRandom();
        }
        //else if (projectile.gameObject.CompareTag("Player"))
        //{
            
        //}
    }
    public void PlaySoundSpeech()
    {
        myAudio.spatialBlend = 1.0f;
        myAudio.minDistance = 1.0f;
        myAudio.maxDistance = 40.0f;
        myAudio.rolloffMode = AudioRolloffMode.Linear;

        playTalkNum = Random.Range(1, 42);
        myAudio.volume = 0.25f;
        switch (playTalkNum)
        {
            case 1:
                myAudio.clip = sound1;
                break;
            case 2:
                myAudio.clip = sound2;
                break;
            case 3:
                myAudio.clip = sound3;
                break;
            case 4:
                myAudio.clip = sound4;
                break;
            case 5:
                myAudio.clip = sound5;
                break;
            case 6:
                myAudio.clip = sound6;
                break;
            case 7:
                myAudio.clip = sound7;
                break;
            case 8:
                myAudio.clip = sound8;
                break;
            case 9:
                myAudio.clip = sound9;
                break;
            case 10:
                myAudio.clip = sound10;
                break;
            case 11:
                myAudio.clip = sound11;
                break;
            case 12:
                myAudio.clip = sound12;
                break;
            case 13:
                myAudio.clip = sound13;
                break;
            case 14:
                myAudio.clip = sound14;
                break;
            case 15:
                myAudio.clip = sound15;
                break;
            case 16:
                myAudio.clip = sound16;
                break;
            case 17:
                myAudio.clip = sound17;
                break;
            case 18:
                myAudio.clip = sound18;
                break;
            case 19:
                myAudio.clip = sound19;
                break;
            case 20:
                myAudio.clip = sound20;
                break;
            case 21:
                myAudio.clip = sound21;
                break;
            case 22:
                myAudio.clip = sound22;
                break;
            case 23:
                myAudio.clip = sound23;
                break;
            case 24:
                myAudio.clip = sound24;
                break;
            case 25:
                myAudio.clip = sound25;
                break;
            case 26:
                myAudio.clip = sound26;
                break;
            case 27:
                myAudio.clip = sound27;
                break;
            case 28:
                myAudio.clip = sound28;
                break;
            case 29:
                myAudio.clip = sound29;
                break;
            case 30:
                myAudio.clip = sound30;
                break;
            case 31:
                myAudio.clip = sound31;
                break;
            case 32:
                myAudio.clip = sound32;
                break;
            case 33:
                myAudio.clip = sound33;
                break;
            case 34:
                myAudio.clip = sound34;
                break;
            case 35:
                myAudio.clip = sound35;
                break;
            case 36:
                myAudio.clip = sound36;
                break;
            case 37:
                myAudio.clip = sound37;
                break;
            case 38:
                myAudio.clip = sound38;
                break;
            case 39:
                myAudio.clip = sound39;
                break;
            case 40:
                myAudio.clip = sound40;
                break;
            case 41:
                myAudio.clip = sound41;
                break;
        }
        myAudio.time = Random.Range(1.0f, myAudio.clip.length);
        myAudio.Play();
    }
    IEnumerator TheftMessage(int memeNum, int numOfStocksStolenTextRef, float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        stocksStolenMessage.SetActive(true);
        stocksStolenMessage2.SetActive(true);
        stocksStolenMessage3.SetActive(true);
        stocksStolenMessage.gameObject.GetComponent<Text>().color = new Color32(176, 44, 53, 255);
        stocksStolenMessage2.gameObject.GetComponent<Text>().color = new Color32(36, 217, 0, 255);
        stocksStolenMessage3.gameObject.GetComponent<Text>().color = new Color32(36, 217, 0, 255);
        if (numOfStocksStolenTextRef > 1)
        {
            stocksStolenMessage.gameObject.GetComponent<Text>().text = "Monster Stole " + numOfStocksStolenTextRef + " Shares from Meme #" + memeNum + " !!!";
            stocksStolenMessage2.gameObject.GetComponent<Text>().text = "Monster Stole " + numOfStocksStolenTextRef + " Shares from Meme #" + memeNum + " !!!";
            stocksStolenMessage3.gameObject.GetComponent<Text>().text = "Monster Stole " + numOfStocksStolenTextRef + " Shares from Meme #" + memeNum + " !!!";
        }
        else
        {
            stocksStolenMessage.gameObject.GetComponent<Text>().text = "Monster Stole " + numOfStocksStolenTextRef + " Share from Meme #" + memeNum + " !!!";
            stocksStolenMessage2.gameObject.GetComponent<Text>().text = "Monster Stole " + numOfStocksStolenTextRef + " Share from Meme #" + memeNum + " !!!";
            stocksStolenMessage3.gameObject.GetComponent<Text>().text = "Monster Stole " + numOfStocksStolenTextRef + " Share from Meme #" + memeNum + " !!!";
        }
        for (int i = 0; i < 85; i++)
        {
            yield return new WaitForSeconds(0.00001f);
            stocksStolenMessage.gameObject.GetComponent<Text>().color = new Color32(0, 0, 0, (byte)(255 - i));
            stocksStolenMessage2.gameObject.GetComponent<Text>().color = new Color32(0, 255, 237, (byte)(255 - i));
            stocksStolenMessage3.gameObject.GetComponent<Text>().color = new Color32(255, 0, 132, (byte)(255 - i));
        }
        stocksStolenMessage.SetActive(false);
        stocksStolenMessage2.SetActive(false);
        stocksStolenMessage3.SetActive(false);
    }
}
