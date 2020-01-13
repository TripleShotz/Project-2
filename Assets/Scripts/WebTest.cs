using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebTest : MonoBehaviour
{
    // use this for initalization
    IEnumerator Start()
    {
        WWW request = new WWW("http://localhost/PRO_2/sqlconnect/webtest.php");
        yield return request;
        string[] webResults = request.text.Split('\t');
        Debug.Log(webResults[0]);
        int webNumber = int.Parse(webResults[1]);
        webNumber *=2;
        Debug.Log(webNumber);
    }


}
