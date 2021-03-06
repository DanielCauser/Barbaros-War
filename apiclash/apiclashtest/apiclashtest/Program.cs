﻿using Nito.AsyncEx;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace apiclashtest
{
    class Program
    {

        static void Main(string[] args)
        {
            AsyncContext.Run(() => MainAsync(args));
        }

        static async void MainAsync(string[] args)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6ImE2NDk1OTNhLTg4YWItNDAzMS1hODRiLWZlODIyODkzZGU2ZSIsImlhdCI6MTQ2MDA3OTc4Mywic3ViIjoiZGV2ZWxvcGVyLzZmYWIwYTAzLTE2ZmEtNzVmNS0xNThiLWIyZTA5MmIyM2EyNCIsInNjb3BlcyI6WyJjbGFzaCJdLCJsaW1pdHMiOlt7InRpZXIiOiJkZXZlbG9wZXIvc2lsdmVyIiwidHlwZSI6InRocm90dGxpbmcifSx7ImNpZHJzIjpbIjIwMS4zMy4xODEuMTMwIl0sInR5cGUiOiJjbGllbnQifV19.cg_0s9BBhqiNpvcHVI95qabQA_WRN9ByrEaLotYiKFn8v4C27KS7n6u1NyV3YWq3iFDbEYyMwonI9RUJEMrSvw";
                    client.BaseAddress = new Uri("https://api.clashofclans.com");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    
                    var response = await client.GetStringAsync("/v1/clans?name=%232VYCV080");

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}