using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundRandom : MonoBehaviour
{
    public List<GameObject> listGround;
    public List<GameObject> listGroundOld;
    Vector3 endPos;
    Vector3 nextPos;
    int groundLen;
    public Transform player;



    // Start is called before the first frame update
    void Start()
    {
        endPos = new Vector3(30f, 0f, 0f);
        for (int i = 1; i < 5 ; i++)
        {
            
            float khoangCach = Random.Range(1f, 5f);
            nextPos = new Vector3(endPos.x + khoangCach, 0f, 0f);
            int groundID = Random.Range(0, listGround.Count);
            GameObject nGround = Instantiate(listGround[groundID], nextPos, Quaternion.identity, transform);
            listGroundOld.Add(nGround);

            switch (groundID)
            {
                case 0: groundLen = 30; break;
                case 1: groundLen = 14; break;
                case 3: groundLen = 21; break;

            }
            endPos = new Vector3(nextPos.x + groundLen, 0f, 0f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(player.position,endPos)<50f){
             for (int i = 1; i < 5 ; i++)
        {
            
            float khoangCach = Random.Range(1f, 5f);
            nextPos = new Vector3(endPos.x + khoangCach, 0f, 0f);
            int groundID = Random.Range(0, listGround.Count);
            GameObject nGround = Instantiate(listGround[groundID], nextPos, Quaternion.identity, transform);
            listGroundOld.Add(nGround);
            switch (groundID)
            {
                case 0: groundLen = 30; break;
                case 1: groundLen = 14; break;
                case 3: groundLen = 21; break;

            }
            endPos = new Vector3(nextPos.x + groundLen, 0f, 0f);
        }
        }
        // if(Vector2.Distance(player.position,listGroundOld[0].transform.position) > 50f){
        //     GameObject getFirst = listGroundOld[0]; //lấy gameObject đầu tiên ra
        //     listGroundOld.RemoveAt(0); // 
        //     Destroy(getFirst);
        // }
    }
}
