using Client.Helpers;
using Client.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Linq.Expressions;
using System.Xml.Linq;
using System.Text;

namespace Client.Logic
{
    public class HTTPLogic
    {
        public static string IP { get; set; } = "";

        public static ushort Port { get; set; }


        public static CreateStatus Create(EntryInModel data)
        {
            CreateStatus status = new CreateStatus();
            using HttpClient client = new HttpClient();

            HttpResponseMessage response = client.PostAsync($"http://{IP}:{Port}/api/create", JsonContent.Create(data, data.GetType(), MediaTypeHeaderValue.Parse("application/json"), new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            })).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.Id = -1;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.Id = int.Parse(responseString);

            return status;
        }

        public GetUpdateDeleteStatus BindNewBorrower(int id, PersonInModel data)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("id", new string[] { id.ToString() });

            HttpResponseMessage response = client.PutAsync($"http://{IP}:{Port}/api/bind-new-borrower", JsonContent.Create(data, data.GetType(), MediaTypeHeaderValue.Parse("application/json"), new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            })).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.SuccessDb = bool.Parse(responseString);

            return status;
        }


        public GetUpdateDeleteStatus UpdateBorrowerName(int id, string expression, string newName)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Patch, $"http://{IP}:{Port}/api/update-borrower-name")
            {
                Headers =
                {

                    { "id", new string[] { id.ToString() } },
                    { "expression", new string[] { expression } },
                    { "newName", new string[] { newName } }
                }
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.SuccessDb = bool.Parse(responseString);

            return status;
        }

        public GetUpdateDeleteStatus UpdateBorrowerClass(int id, string expression, string className)
        {

            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Patch, $"http://{IP}:{Port}/api/update-borrower-class")
            {
                Headers =
                {

                    { "id", new string[] { id.ToString() } },
                    { "expression", new string[] { expression } },
                    { "className", new string[] { className } }
                }
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.SuccessDb = bool.Parse(responseString);

            return status;

        }

        public GetUpdateDeleteStatus UpdateBorrowerBuilding(int id, string expression, string building)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Patch, $"http://{IP}:{Port}/api/update-borrower-building")
            {
                Headers =
                {

                    { "id", new string[] { id.ToString() } },
                    { "expression", new string[] { expression } },
                    { "building", new string[] { building } }
                }
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.SuccessDb = bool.Parse(responseString);

            return status;
        }

        public GetUpdateDeleteStatus UnbindBorrower(int entryId, string expression)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, $"http://{IP}:{Port}/api/unbind-borrower")
            {
                Headers =
                {

                    { "entryId", new string[] { entryId.ToString() } },
                    { "expression", new string[] { expression } }
                }
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.SuccessDb = bool.Parse(responseString);

            return status;
        }

        public (EntryOutModel, GetUpdateDeleteStatus) GetById(int id)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"http://{IP}:{Port}/api/get-by-id")
            {
                Headers =
                {
                    { "id", new string[] { id.ToString() } }
                }
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return (new EntryOutModel() { Name = "Ошибка" }, status);
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;

            EntryOutModel model = responseString.EntryOutModelJsonToClass();

            status.SuccessDb = true;

            return (model, status);
        }

        public (List<EntryOutModel>, GetUpdateDeleteStatus) GetAll()
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"http://{IP}:{Port}/api/get-all");

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return (new List<EntryOutModel>(new[] { new EntryOutModel() { Name = "Ошибка" } }), status);
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;

            List<EntryOutModel> models = responseString.MultEntryOutModelsJsonToClassBulk().ToList();

            status.SuccessDb = true;

            return (models, status);
        }

        public (List<EntryOutModel>, GetUpdateDeleteStatus) Search(string searchTerm)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"http://{IP}:{Port}/api/get-search")
            {
                Headers =
                {
                    { "searchTerm", new string[] { searchTerm } }
                }
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return (new List<EntryOutModel>(new[] { new EntryOutModel() { Name = "Ошибка" } }), status);
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;

            List<EntryOutModel> models = responseString.MultEntryOutModelsJsonToClassBulk().ToList();

            status.SuccessDb = true;

            return (models, status);
        }

        public GetUpdateDeleteStatus UpdateState(int id, string state)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Patch, $"http://{IP}:{Port}/api/update-state")
            {
                Headers =
                {
                    { "id", new string[] { id.ToString() } },
                    { "state", new string[] { state } }
                }
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.SuccessDb = bool.Parse(responseString);

            return status;
        }

        public GetUpdateDeleteStatus UpdateName(int id, string name)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Patch, $"http://{IP}:{Port}/api/update-name")
            {
                Headers =
                {
                    { "id", new string[] { id.ToString() } },
                    { "name", new string[] { name } }
                }
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.SuccessDb = bool.Parse(responseString);

            return status;
        }

        public GetUpdateDeleteStatus UpdateQuantity(int id, uint quantity)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Patch, $"http://{IP}:{Port}/api/update-quantity")
            {
                Headers =
                {
                    { "id", new string[] { id.ToString() } },
                    { "quantity", new string[] { quantity.ToString() } }
                }
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.SuccessDb = bool.Parse(responseString);

            return status;
        }

        public GetUpdateDeleteStatus UpdateUnit(int id, string unit)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Patch, $"http://{IP}:{Port}/api/update-unit")
            {
                Headers =
                {
                    { "id", new string[] { id.ToString() } },
                    { "unit", new string[] { unit } }
                }
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.SuccessDb = bool.Parse(responseString);

            return status;
        }

        public GetUpdateDeleteStatus UpdateDescription(int id, string description)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Patch, $"http://{IP}:{Port}/api/update-desc")
            {
                Content = new ByteArrayContent(System.Text.Encoding.Unicode.GetBytes(((new char[] { (char)34 }).Concat(description.ToCharArray()).Concat(new char[] { (char)34 })).ToArray())),
                Headers =
                {
                    { "id", new string[] { id.ToString() } }
                }
            };

            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.SuccessDb = bool.Parse(responseString);

            return status;
        }

        public GetUpdateDeleteStatus UpdateOwner(int id, string owner)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Patch, $"http://{IP}:{Port}/api/update-owner")
            {
                Headers =
                {
                    { "id", new string[] { id.ToString() } },
                    { "owner", new string[] { owner } }
                }
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.SuccessDb = bool.Parse(responseString);

            return status;
        }

        public GetUpdateDeleteStatus Delete(int id)
        {
            GetUpdateDeleteStatus status = new GetUpdateDeleteStatus();
            using HttpClient client = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, $"http://{IP}:{Port}/api/delete")
            {
                Headers =
                {
                    { "id", new string[] { id.ToString() } },
                }
            };

            HttpResponseMessage response = client.SendAsync(request).Result;

            if (!response.IsSuccessStatusCode)
            {
                status.SuccessRet = false;
                status.SuccessDb = false;

                return status;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;

            status.SuccessRet = true;
            status.SuccessDb = bool.Parse(responseString);

            return status;
        }
    }
}

