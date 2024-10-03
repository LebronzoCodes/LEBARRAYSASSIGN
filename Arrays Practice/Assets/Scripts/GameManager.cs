using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variables

    //Create an array of strings

    public string[] students = new string[7] {"Colllin", "Joseph", "Emmanuel", "Lebron", "Justin", "Bella", "Evri"};

    private string stu1 = "Colin"; 

    public GameObject[] floors;

    //Make a list of strings

    public List<string> stulist = new List<string>(); 

    // Start is called before the first frame update
    void Start()
    {
        //Change the last student's spelling to stu1

        students[1] = stu1;

        //Add all the students from the array to the list
        stulist.AddRange(students);

        //Make a new array with all of the students that are here.
        students = new string[6] { "Colin", "Joseph", "Emmanuel", "Lebron", "Justin", "Bella" };

        //Remove the student that isn't here from the list. 
        stulist.Remove("Evri");

      
        //floors = GameObject.FindGameObjectsWithTag("floor")
    }

    // Update is called once per frame
    void Update()
    {
        //Prints the number of items within the list and the array

        //Lists use Count
            //Debug.Log(stulist.Count);

        //Array uses Length
            //Debug.Log(students.Length);

        //Note: you use students.length - 1 if there is an equals (=, <=, >=), otherwise use just students.length
        for (int i = 0; i<students.Length; i++)
        {
            Debug.Log(students[i]);
        }
    }
}
