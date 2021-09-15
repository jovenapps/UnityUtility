using System;
using System.Collections;
using System.Collections.Generic;

namespace Utility 
{


    ///<summary>
    /// Lists contains common methods used by developers in debugging lists.
    /// Author: Carl Joven (JovenApps)
    ///</summary>
    public static class Lists
    {

        #region STRINGS and LISTS

        // Converting a list to a comma separated variable string.
        public static string ToCSV<T> (List<T> data)
        {
            string csv = "";
            if (data == null || data.Count <= 0)
                return csv;

            int count = data.Count;
            csv = data[0].ToString();
            for (int i = 1; i < count; i++)
            {
                csv += $",{((object)data[i]).ToString()}";
            }
            return csv;
        }

        // Converting a array to a comma separated variable string.
        public static string ToCSV<T> (T[] data)
        {
            string csv = "";
            if (data == null || data.Length <= 0)
                return csv;

            int count = data.Length;
            csv = data[0].ToString();
            for (int i = 1; i < count; i++)
            {
                csv += $",{((object)data[i]).ToString()}";
            }
            return csv; 
        }

        // Converting a list to a comma separated variable string.
        public static string ToString<T> (List<T> data)
        {
            return ToCSV<T>(data);
        }

        // Converting an integer array to a comma separated variable string.
        public static string ToString<T> (T[] data)
        {
            return ToCSV<T>(data);
        }

        // Log is a commonly used to convert a list (or object) to a string
        public static string Log<T>(List<T> data)
        {
            return ToCSV<T>(data);
        }

        public static string Log<T>(string label, List<T> data)
        {
            return $"{label}: {ToCSV<T>(data)}";
        }

        public static string Log<T>(T[] data)
        {
            return ToCSV<T>(data);
        }

        public static string Log<T>(string label, T[] data)
        {
            return $"{label}: {ToCSV<T>(data)}";
        }

        public static List<int> CSVToListInt(string valueString)
        {
            string[] values = valueString.Split(',');
            List<int> valueList = new List<int>();
            for(int i=0; i < values.Length; i++)
            {
                int content = 0;
                if( int.TryParse( values[i], out content ) )
                {
                    valueList.Add( content );
                }
            }
            return valueList;
        }

        public static List<long> CSVToListLong (string valueString)
        {
            string [] values = valueString.Split (',');
            List<long> valueList = new List<long> ();
            for (int i = 0; i < values.Length; i++)
            {
                long content = 0;
                if (long.TryParse (values [i], out content))
                {
                    valueList.Add (content);
                }
            }
            return valueList;
        }

        public static List<float> CSVToListFloat(string valueString)
        {
            string[] values = valueString.Split(',');
            List<float> valueList = new List<float>();
            for(int i=0; i < values.Length; i++)
            {
                float content = 0;
                if( float.TryParse( values[i], out content ) )
                {
                    valueList.Add( content );
                }
            }
            return valueList;
        }

        public static List<double> CSVToListDouble(string valueString)
        {
            string[] values = valueString.Split(',');
            List<double> valueList = new List<double>();
            for(int i=0; i < values.Length; i++)
            {
                double content = 0;
                if( double.TryParse( values[i], out content ) )
                {
                    valueList.Add( content );
                }
            }
            return valueList;
        }

        public static List<string> CSVToListString (string valueString)
        {
            string [] values = valueString.Split (',');
            return new List<string> (values);
        }

        public static int[] CSVToArrayInt(string valueString)
        {
            List<int> l = CSVToListInt(valueString);
            return l.ToArray();
        }

        public static long[] CSVToArrayLong(string valueString)
        {
            List<long> l = CSVToListLong(valueString);
            return l.ToArray();
        }

        public static float[] CSVToArrayFloat(string valueString)
        {
            List<float> l = CSVToListFloat(valueString);
            return l.ToArray();
        }

        public static double[] CSVToArrayDouble(string valueString)
        {
            List<double> l = CSVToListDouble(valueString);
            return l.ToArray();
        }

        public static string[] CSVToArrayString(string valueString)
        {
            string [] values = valueString.Split (',');
            return values;
        }
 
        
        #endregion

        #region COMPARISON

        public static bool CompareList(List<int> a, List<int> b)
        {
            if(a == null || b == null)
                return false;

            if(a.Count <= 0 || b.Count <= 0)
                return false;

            if(a.Count != b.Count)
                return false;

            bool equalList = true;
            for(int i=0; i < a.Count; i++)
            {
                if(a[i] != b[i])
                {
                    equalList = false;
                    break;
                }
            }
            return equalList;
        }
        
        #endregion



        #region RANDOM

        // Creates a list of indexes that is in a random sort order. This is useful for randomizing a set of game data.
        public static List<int> RandomizeListIndex(int length)
        {
            List<int> randomizedList = new List<int>();
            List<int> indexList = new List<int>();

            // Create an index list (0,1,.... length-1)
            for(int i=0; i < length; i++)
            {
                indexList.Add(i);
            }

            var rand = new Random();
            for(int i=0; i < length; i++)
            {
                // Pick a random index then assign it to our list
                // int rand = UnityEngine.Random.Range(0, indexList.Count);
                int r = rand.Next(indexList.Count);

                randomizedList.Add( indexList[r] );
                indexList.RemoveAt(r);
            }

            return randomizedList;
        }

        public static List<T> RandomizeList<T>(List<T> data)
        {
            if(data == null || data.Count <= 0)
                return new List<T>();

            List<int> randomIndices = RandomizeListIndex(data.Count);
            List<T> randomData = new List<T>();
            for(int i=0; i < data.Count; i++)
            {
                randomData.Add(data[randomIndices[i]]);
            }
            return randomData;
        }

        #endregion

    }
}