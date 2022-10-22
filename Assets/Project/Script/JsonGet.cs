using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

class Anime
{
    public int id { get; set; }
    public string? title { get; set; }
    public string? title_short1 { get; set; }
    public string? title_short2 { get; set; }
    public string? title_short3 { get; set; }
    public string? title_en { get; set; }
    public string? public_url { get; set; }
    public string? twitter_account { get; set; }
    public string? twitter_hash_tag { get; set; }
    public int cours_id { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public int? sex { get; set; }
    public int? sequel { get; set; }
    public int? city_code { get; set; }
    public string? city_name { get; set; }
    public string? product_companies { get; set; }
    public string? ogp_image_url { get; set; }
    public string? ogp_description { get; set; }
}

public class JsonGet : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {
        UnityWebRequest www = UnityWebRequest.Get("https://raw.githubusercontent.com/OHMORIYUSUKE/animeapp-db/api/2022-4.json");
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            // 結果をテキストとして表示します
            // Debug.Log(www.downloadHandler.text);

            var animeList = JsonSerializer.Deserialize<Anime[]>(www.downloadHandler.text);

            for (int i = 0; i < animeList.Length; i++)
            {
                Debug.Log(animeList[i].title);
            }

            //  または、結果をバイナリデータとして取得します
            byte[] results = www.downloadHandler.data;
        }
    }
}
