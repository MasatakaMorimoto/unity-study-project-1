﻿using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    void Start()
    {
        int answer;
        answer = Add(2, 3);
        Debug.Log(answer);
    }
}