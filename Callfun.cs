using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
namespace Assignment27
{

    public class Callfun : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int a = 3;
            int b = 5;
            AddByValue(a);
            Debug.Log(a);
            AddByRefernce(ref b);
            Debug.Log(b);
            AddWithOut(out int c);
            Debug.Log(c);
        }


        public void AddByValue(int a)
        {
            a += 10;
        }
        public void AddByRefernce(ref int a)
        {
            a += 10;
        }
        public void AddWithOut(out int a)
        {

            a = 130;

        }
    }
}