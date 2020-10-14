using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml;
using UnityEngine.Networking;
public class ReadWeatherXML : MonoBehaviour
{
    string key = "ce2cea1713381b228c38eb71ac67330e"; // A validation Key.
    
    public string zip;
    
    string apiReturn = "";    //Storing API information

    public GameObject rainEmitter; //Game Object
    
    [Header("Values are written to")] // A display text 
    
    public string precipitationState;  //Identifier 
    void Start()
    {
        StartCoroutine(GetWeather());
    }

    void Update()
    {
        if (apiReturn.Length <= 0) //A conditional Statement for api return 
            return;
        else
        {
            //Debug.Log(apiReturn.IndexOf("precipitation mode"));
            if(apiReturn.IndexOf("precipitation mode") != -1)
            {
                int pmStart = apiReturn.IndexOf("precipitation"); //Start of Index Search
                int pmEnd = apiReturn.IndexOf("/precipitation");  //End of Index Search
                //int modeIndex = precipModeIndex + 20;

                int theRightMode = apiReturn.IndexOf("mode", pmStart, pmEnd - pmStart); //api search with index start and index end as parameters

                int indexOfMode = theRightMode + 6; // searching for information located in index 6
                precipitationState = apiReturn.Substring(indexOfMode, 1);// searching precipitation state for an api return w/ a substring ranging from indexofmode to 1
                Debug.Log("returning a value"); 

                
            }
        }
        if (precipitationState.Contains("r")) //searcing precipitation state to see if it contains 'r' and if so the game object rainemitter is turned on. 
            rainEmitter.SetActive(true);
    }

    IEnumerator GetWeather()
    {
        UnityWebRequest www = UnityWebRequest.
            Get("http://api.openweathermap.org/data/2.5/weather?zip=" + zip + "&mode=xml&APPID=" + key);
        yield return www.SendWebRequest();
        if (!www.isNetworkError && !www.isHttpError)
        {
            // Get text content like this:
            Debug.Log(www.downloadHandler.text);
            apiReturn = www.downloadHandler.text; //
        }
        else
        {
            Debug.Log(www.error + " " + www);
        }
    }
}

