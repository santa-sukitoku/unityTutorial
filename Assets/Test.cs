﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, World!");

        int age;
        age = 30;
        Debug.Log(age);

        float height1 = 160.5f;
        float height2;
        height2 = height1;
        Debug.Log(height2);

        string name;
        name = "kitamura";
        Debug.Log(name);

        int answer;
        answer = 1 + 2;
        Debug.Log(answer);
        answer = 3 - 4;
        Debug.Log(answer);
        answer = 6 * 5;
        Debug.Log(answer);
        answer = 8 / 4;
        Debug.Log(answer);

        int n1 = 8;
        int n2 = 9;
        answer = n1 + n2;
        Debug.Log(answer);

        int herbNum = 1;
        if (herbNum == 1) {
            Debug.Log("HPが50回復");
        }

        int hp = 180;
        if (hp <= 50) {
            Debug.Log("逃走!");
        } else if (hp >= 200) {
            Debug.Log("攻撃!");
        } else {
            Debug.Log("防御!");
        }

        for (int i = 0; i < 5; i++) {
            Debug.Log(i);
        }

        for (int i = 0; i < 10; i += 2) {
            Debug.Log(i);
        }

        for (int i = 3; i <= 5; i++) {
            Debug.Log(i);
        }

        for (int i = 3; i >= 0; i--) {
            Debug.Log(i);
        }

        int sum = 0;
        for(int i = 1; i <= 10; i++) {
            sum += 1;
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
