using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawnIfFall : MonoBehaviour
{
    public Transform respawnPoint;
    public GameObject respawnText;
    public Color textOn;
    public Color textOff;
    

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            respawnText.SetActive(true);
            respawnText.GetComponent<TextMesh>().color = textOn;
            other.gameObject.transform.position = respawnPoint.position;
            StartCoroutine(FadeText());
        }
    }
    IEnumerator FadeText()
    {
        if(respawnText.GetComponent<TextMesh>().color.a > 0)
        {
            yield return new WaitForSeconds(2.0f);
            respawnText.GetComponent<TextMesh>().color = textOff;;
        } else {
            respawnText.SetActive(false);
        }
        
    }
}
