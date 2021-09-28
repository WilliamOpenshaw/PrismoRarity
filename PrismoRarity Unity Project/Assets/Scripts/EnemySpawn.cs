using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy1;

    public GameObject enemy2; 
    public Target enemyScript;
    public Target enemyScript2;
   
    public int spawnPointChoice;
    public int spawnPointChoice2;
    public int spawnPointSwitch;

    //public firePlayerGun shootingScript;
    // Start is called before the first frame update

    public void RespawnEnemy()
    {
        //shootingScript
        //spawn enemies at random of four spawn loactions
        spawnPointChoice = Random.Range(0, 22);
        spawnPointChoice2 = Random.Range(0, 22);
        while (spawnPointChoice2 == spawnPointChoice)
        {
            spawnPointChoice2 = Random.Range(1, 22);
        }
        spawnPointSwitch = Random.Range(1, 11);
        switch (spawnPointSwitch)
        {
            case 1:
                GameObject newEnemy1 = Instantiate(enemy1, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice].transform.position, transform.rotation);
                newEnemy1.GetComponent<Target>().PlaySoundSpeech(); 
                newEnemy1.tag = "Enemy";           
                break;
            case 2:                
                GameObject newEnemy2 = Instantiate(enemy2, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice].transform.position, transform.rotation);
                newEnemy2.GetComponent<Target>().PlaySoundSpeech();                
                newEnemy2.tag = "Enemy";  
                break;
            case 3:
                GameObject newEnemy5 = Instantiate(enemy1, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice].transform.position, transform.rotation);
                GameObject newEnemy6 = Instantiate(enemy2, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice2].transform.position, transform.rotation);
                newEnemy5.GetComponent<Target>().PlaySoundSpeech();
                newEnemy5.tag = "Enemy";  
                newEnemy6.tag = "Enemy";  
                break;
            case 4:
                GameObject newEnemy7 = Instantiate(enemy1, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice].transform.position, transform.rotation);
                GameObject newEnemy8 = Instantiate(enemy2, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice2].transform.position, transform.rotation);
                newEnemy7.GetComponent<Target>().PlaySoundSpeech();
                newEnemy7.tag = "Enemy";  
                newEnemy8.tag = "Enemy";  
                break;
            case 5:
                GameObject newEnemy9 = Instantiate(enemy1, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice].transform.position, transform.rotation);
                GameObject newEnemy10 = Instantiate(enemy1, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice2].transform.position, transform.rotation);
                newEnemy9.GetComponent<Target>().PlaySoundSpeech();
                newEnemy9.tag = "Enemy";  
                newEnemy10.tag = "Enemy";  
                break;
            case 6:
                GameObject newEnemy11 = Instantiate(enemy2, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice].transform.position, transform.rotation);
                GameObject newEnemy12 = Instantiate(enemy2, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice2].transform.position, transform.rotation);
                newEnemy11.GetComponent<Target>().PlaySoundSpeech();
                newEnemy11.tag = "Enemy";  
                newEnemy12.tag = "Enemy";  
                break;
            case 7:
                GameObject newEnemy13 = Instantiate(enemy1, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice].transform.position, transform.rotation);
                newEnemy13.GetComponent<Target>().PlaySoundSpeech();  
                newEnemy13.tag = "Enemy";                
                break;
            case 8:                
                GameObject newEnemy14 = Instantiate(enemy2, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice].transform.position, transform.rotation);
                newEnemy14.GetComponent<Target>().PlaySoundSpeech();
                newEnemy14.tag = "Enemy";  
                break;
            case 9:
                GameObject newEnemy15 = Instantiate(enemy1, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice].transform.position, transform.rotation);
                newEnemy15.GetComponent<Target>().PlaySoundSpeech();   
                newEnemy15.tag = "Enemy";           
                break;
            case 10:                
                GameObject newEnemy16 = Instantiate(enemy2, GameObject.FindGameObjectsWithTag("EnemySpawn")[spawnPointChoice].transform.position, transform.rotation);
                newEnemy16.GetComponent<Target>().PlaySoundSpeech();
                newEnemy16.tag = "Enemy";  
                break;
        }
    }
}

