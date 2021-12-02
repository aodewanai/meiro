using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anime;

    void Start()
    {
        anime = GetComponent<Animator>();

    }

    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            anime.SetBool("walkingHorizontalRight", true);

            anime.SetBool("walkingHorizontal", false);
            anime.SetBool("walkingVertical", false);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anime.SetBool("walkingHorizontal", true);

            anime.SetBool("walkingHorizontalRight", false);
            anime.SetBool("walkingVertical", false);
        }
        else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            anime.SetBool("walkingVertical", true);
            
            anime.SetBool("walkingHorizontal", false);
            anime.SetBool("walkingHorizontalRight", false);

        }
        else
        {
            anime.SetBool("walkingHorizontal", false);
            anime.SetBool("walkingHorizontalRight", false);
            anime.SetBool("walkingVertical", false);
        }
    }
}
