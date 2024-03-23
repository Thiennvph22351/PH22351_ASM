using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour

{   
    public Animator animator;
    float timer;
    private void Start(){
        animator= GetComponent<Animator>();
    }
    private void Update(){
        timer += Time.deltaTime;
        float loop = Random.Range(3f,7f);
        if(timer >= loop){
            animator.SetTrigger("Atk");
            timer = 0f;
        }
    }

    // Start is called before the first frame update
    public Transform bulletPos;
    public GameObject bullet;
    public void PlantShoot(){
        Instantiate(bullet,bulletPos.position,Quaternion.identity);
    }
}
