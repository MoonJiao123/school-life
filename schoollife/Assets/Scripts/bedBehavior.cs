﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bedBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
