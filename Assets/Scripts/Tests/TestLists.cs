using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utility;


public class TestLists 
{

    // Log the csv result from a set of numbers
    public void TestListCSV(params int[] numbers)
    {
        List<int> l = new List<int>(numbers);
        Debug.Log($"Testing int list ToCSV: {Lists.ToCSV(l)}"); 
        
        List<int> randList = Lists.RandomizeList<int>(l);
        Debug.Log($"Testing int random: {Lists.ToString(randList)}");
    }

    public void TestListCSV(params long[] numbers)
    {
        List<long> l = new List<long>(numbers);
        string result = Lists.ToCSV(l);
        Debug.Log($"Testing long list to csv: {result}");
    }

    public void TestListCSV(params float[] numbers)
    {
        List<float> l = new List<float>(numbers);
        string result = Lists.ToCSV(l);
        Debug.Log($"Testing float list to csv: {result}");

        List<float> randList = Lists.RandomizeList<float>(l);
        Debug.Log($"Testing float random: {Lists.ToString(randList)}");
    }

    public void TestListCSV(params double[] numbers)
    {
        List<double> l = new List<double>(numbers);
        string result = Lists.ToCSV(l);
        Debug.Log($"Testing double list to csv: {result}");
    }

    public void TestListCSV(params string[] numbers)
    {
        List<string> l = new List<string>(numbers);
        string result = Lists.ToCSV(l);
        Debug.Log($"Testing string list to csv: {result}");

        List<string> randList = Lists.RandomizeList<string>(l);
        Debug.Log($"Testing string random: {Lists.ToString(randList)}");
    }

}
