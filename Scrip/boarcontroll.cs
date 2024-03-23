using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boarcontroll : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sr;
    public Animator anim;
    public Transform boar;
    public Transform posA;
    public Transform posB;

    bool isFaceRight;
    float speedMove =3f;

    private void Update(){
        if(isFaceRight){
            if(Vector2.Distance(boar.position, posB.position)>0.1f){
                boar.position = Vector3.MoveTowards(boar.position, posB.position, speedMove * Time.deltaTime);
                anim.Play("botWalk");
            }else{
                isFaceRight = false;
                sr.flipX = false;
            }
            
        }else{
            if(Vector2.Distance(boar.position, posA.position)>0.1f){
                boar.position = Vector3.MoveTowards(boar.position, posA.position, speedMove * Time.deltaTime);
                anim.Play("botWalk");
            }else{
                isFaceRight = true;
                sr.flipX = true;
            }
        }
    }
}
