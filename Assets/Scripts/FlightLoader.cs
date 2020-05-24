using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightLoader : MonoBehaviour
{
    public List<Flight> flights;

    void Awake()
    {
        flights = new List<Flight>();
        FlightDictionary dictionary = JsonUtility.FromJson<FlightDictionary>(JsonFileReader.LoadJsonAsResource("FlightDictionary.json"));
        foreach(string dictionaryItem in dictionary.flights) 
        {
            LoadFlight(dictionaryItem);
        }
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadFlight(string path){
        string myLoadedItem = JsonFileReader.LoadJsonAsResource(path);
        Debug.Log("my flights " + myLoadedItem);
        Flight myFlights = JsonUtility.FromJson<Flight>(myLoadedItem);
        flights.Add(myFlights);
    }
}
