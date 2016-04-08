using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BARBAROS.REPOSITORIO_EXTERNO
{
    public class MembrosClanRepositorioExterno : IMembrosClanRepositorioExterno
    {
        public string BuscarMembrosBarbarosWar()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiIsImtpZCI6IjI4YTMxOGY3LTAwMDAtYTFlYi03ZmExLTJjNzQzM2M2Y2NhNSJ9.eyJpc3MiOiJzdXBlcmNlbGwiLCJhdWQiOiJzdXBlcmNlbGw6Z2FtZWFwaSIsImp0aSI6IjQ3MmFhZDZmLWFjYWQtNGJjYS1iYjcyLWVmZWQ1ZjQxNzc1ZSIsImlhdCI6MTQ2MDE0NDMxNywic3ViIjoiZGV2ZWxvcGVyLzZmYWIwYTAzLTE2ZmEtNzVmNS0xNThiLWIyZTA5MmIyM2EyNCIsInNjb3BlcyI6WyJjbGFzaCJdLCJsaW1pdHMiOlt7InRpZXIiOiJkZXZlbG9wZXIvc2lsdmVyIiwidHlwZSI6InRocm90dGxpbmcifSx7ImNpZHJzIjpbIjE5OC4zNy4xMTYuMjkiLCIyMDEuMzMuMTgxLjEzMCJdLCJ0eXBlIjoiY2xpZW50In1dfQ.rEfwPzq2H0ZjCg4FkaJ24-0pRpM3NIvOS8z-iRYhC95-YDTQBEXCEXjL0m2QzcBi2YpW01YT---9x3E5oFmsVg";
                    client.BaseAddress = new Uri("https://api.clashofclans.com");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                    var response = client.GetStringAsync("/v1/clans/%232VYCV080/members").Result;
                    return response;
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
