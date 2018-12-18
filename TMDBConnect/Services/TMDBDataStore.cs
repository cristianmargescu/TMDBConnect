using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TMDbLib.Client;
using TMDBConnect.Models;

namespace TMDBConnect.Services
{
    public class TMDBDataStore : IDataStore<Item>
    {
        TMDbClient client;
        IEnumerable<Item> items;

        public TMDBDataStore()
        {
            client = new TMDbClient($"{App.APIKey}/");

            items = new List<Item>();
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            if (forceRefresh)
            {
                //var json = await client.GetStringAsync($"api/item");
                //items = await Task.Run(() => JsonConvert.DeserializeObject<IEnumerable<Item>>(json));
                return null;
            }

            return items;
        }

        public async Task<Item> GetItemAsync(string id)
        {
            if (id != null)
            {
                //var json = await client.GetStringAsync($"api/item/{id}");
                //return await Task.Run(() => JsonConvert.DeserializeObject<Item>(json));
                return null;
            }

            return null;
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            if (item == null)
                return false;

            //var serializedItem = JsonConvert.SerializeObject(item);

            //var response = await client..PostAsync($"api/item", new StringContent(serializedItem, Encoding.UTF8, "application/json"));

            //return response.IsSuccessStatusCode;

            return true;
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            if (item == null || item.Id == null)
                return false;

            var serializedItem = JsonConvert.SerializeObject(item);
            var buffer = Encoding.UTF8.GetBytes(serializedItem);
            var byteContent = new ByteArrayContent(buffer);

            //var response = await client.PutAsync(new Uri($"api/item/{item.Id}"), byteContent);

            //return response.IsSuccessStatusCode;

            return true;
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
                return false;

            //var response = await client.DeleteAsync($"api/item/{id}");

            //return response.IsSuccessStatusCode;

            return true;
        }
    }
}