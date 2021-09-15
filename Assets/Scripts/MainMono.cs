using UnityEngine;

using Utility;

public class MainMono : MonoBehaviour
{
    void Start ()
    {
        StartListTests();
    }


    void StartListTests ()
    {
        TestLists test = new TestLists();
        test.TestListCSV(1,2,3,4,5);
        test.TestListCSV(1.1f,2.2f,3.3f,4.4f,5.5f);
        test.TestListCSV(10.0,20.0,30.0,40.0,50.0);
        test.TestListCSV("a", "b", "c", "d", "e");
    }
}