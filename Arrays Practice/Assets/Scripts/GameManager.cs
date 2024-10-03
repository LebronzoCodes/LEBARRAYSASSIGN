using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variables

    //Create an array of strings

    public string[] students = new string[7] {"Colin", "Joseph", "Emmanuel", "Lebron", "Justin", "Bella", "Evri"};

    private string stu1 = "Colin"; 

    // Start is called before the first frame update
    void Start()
    {
        students[6] = stu1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
