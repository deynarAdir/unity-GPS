using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// using System.Web.Script.Serialization;
public class GPSLocation : MonoBehaviour
{
    // Start is called before the first frame update

    public float latitud;
    public float longitud;
    public Text gpsText;

    public 
    void Start()
    {
        if(Input.location.isEnabledByUser)
        StartCoroutine(GetLocation());
    }

    private IEnumerator GetLocation()
    {
        Input.location.Start();
        while(Input.location.status == LocationServiceStatus.Initializing)
        {
            yield return new WaitForSeconds(0.5f);
        }

        latitud = Input.location.lastData.latitude;
        longitud = Input.location.lastData.longitude;
        yield break;

    }

    // Update is called once per frame
    void Update()
    {
        longitud = Input.location.lastData.longitude;
        latitud = Input.location.lastData.latitude;
        //gpsText.text = "Latitud:"+latitud + " Longitud "+ longitud;

        if((latitud > (-16.5922551816694-0.0050) && latitud < (-16.5922551816694+0.0050)) && (longitud > (-68.17534457988631-0.0050) && longitud < (-68.17534457988631+0.0050))){
            // # Lugar: Churasqueria el Chaqueño
            gpsText.text = "Latitud:"+latitud + " Longitud "+ longitud;
        }else if((latitud > (-16.597396162846582-0.0050) && latitud < (-16.597396162846582+0.0050)) && (longitud > (-68.17279111694515-0.0050) && longitud < (-68.17279111694515+0.0050))){
            // # Lugar: Feria de Nueva Esperanza
            gpsText.text = "Latitud:"+latitud + " Longitud "+ longitud;
        }else if((latitud > (-16.59221405326573-0.0050) && latitud < (-16.59221405326573+0.0050)) && (longitud > (-68.17311298202175-0.0050) && longitud < (-68.17311298202175+0.0050))){
            // # Lugar: Mercado campesino 8 de mayo
            gpsText.text = "Latitud:"+latitud + " Longitud "+ longitud;
        }

        gpsText.text = "No existen lugares de comida cercanos";


        /*var obj = new Place
        {
            lat = -16.5922551816694,
            lon = -68.17534457988631,
            des = "Churrasqueria El Chaqueño"
        };*/

        /*Place place1 = new Place(-16.5922551816694, -68.17534457988631, "Churrasqueria El Chaqueño");
        Place place1 = new Place(-16.597396162846582, -68.17279111694515, "Feria de nueva Esperanza");
        Place place1 = new Place(-16.59221405326573, -68.17311298202175, "Mercado campesino 8 de mayo");*/

        // gpsText.text = json + " jajaja";

    }

    
}

// public class Place{
//     public double lat;
//     public double lon;
//     public string des;

//     public Place(lat, lon, des){
//         this.lat = lat;
//         this.lon = lon;
//         this.des = des;
//     }
// }

