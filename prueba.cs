using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        Object[] GameobjectList = Resources.FindObjectsOfTypeAll(typeof(GameObject));
        
        foreach (Object obj in GameobjectList) {
            Debug.Log(obj.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.sumOne();
        print("El contador está a: " + gameObject.Count());
    }
}

public static class GameObjectExtensions {
     private static int _count = 0;
 
     public static int Count(this GameObject gameObject) {
         return _count;
     }
     public static void sumOne(this GameObject gameObject) {
         _count += 1;
     }
 }