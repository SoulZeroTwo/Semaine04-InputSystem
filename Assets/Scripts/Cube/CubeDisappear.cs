using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDisappear : MonoBehaviour
{
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        Invoke("Anim", 7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Disappear starts the disappearing animation.
    void Anim()
    {
        // Catches the current time since the function started.
        _anim.SetBool("isDisappearing", true);
        Invoke("Disappear", 3f);
    }

    void Disappear()
    {
        Destroy(gameObject);
    }
}
