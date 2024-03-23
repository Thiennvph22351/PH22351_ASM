using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpamCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform players;
    public GameObject coin;
    bool enableSpawn;
    private void Start(){
        enableSpawn = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(enableSpawn){
            enableSpawn = false;
            float viTriX = players.position.x + Random.Range(15f,30f);
            float viTriY = Mathf.Sin(viTriX);

            int soLuong = Random.Range(5, 16);
            for (int i = 0; i < soLuong; i++)
            {
                
                Instantiate(coin, new Vector3(viTriX,viTriY,0),Quaternion.identity,transform);
                viTriX++;
                viTriY = Mathf.Sin(viTriX);
            }
            // thuc hien sinh coin
            

            StartCoroutine(delayForSpawn());
            // cho 5-10s thi enableSpawn = true
        }
    }
    IEnumerator delayForSpawn(){
        float timer = Random.Range(5f,10f);
        yield return new WaitForSeconds(timer);
        enableSpawn = true;
        //thuc hien

    }
}
