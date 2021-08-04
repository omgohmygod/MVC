using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Medical_CheckIn_System
{
    class Client
    {
        static string Post(string id, string name, string number, string uri)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // 建構 Json 物件
                    var result = new
                    {
                        ID = id,
                        patient = new
                        {
                            Name = name,
                            Number = number
                        }
                    };

                    // 設定 Timeout 10秒連不上 Server 中斷
                    client.Timeout = TimeSpan.FromSeconds(10);
                    // 轉 Json
                    string json = JsonConvert.SerializeObject(result);
                    // 傳送內容
                    HttpContent contentPost = new StringContent(json);
                    // 發 Post
                    HttpResponseMessage response = client.PostAsync(uri, contentPost).GetAwaiter().GetResult();
                    // 確認回傳是否成功，失敗進入catch
                    response.EnsureSuccessStatusCode();
                    // 回傳接收到的 string
                    return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }
                catch (HttpRequestException)
                {
                    Console.WriteLine("伺服器未開啟或錯誤");
                    return null;
                }
                catch (System.Threading.Tasks.TaskCanceledException)
                {
                    return null;
                }

            }
        }
    }
}
