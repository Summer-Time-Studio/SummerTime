using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaChangeAnim : MonoBehaviour
{

    Animator animator;
    private float anim_speed;
    public float min_distance = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
