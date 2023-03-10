﻿using RemindRx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemindRx.Services
{
    public class MockDataStoreContact : IDataStore<EContact>
    {
        readonly List<EContact> contacts;

        public MockDataStoreContact()
        {
            contacts = new List<EContact>()
            {
                //new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                //new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                //new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                //new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                //new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                //new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };
        }

        public async Task<bool> AddItemAsync(EContact item)
        {
            contacts.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(EContact item)
        {
            var oldItem = contacts.Where((EContact arg) => arg.Id == item.Id).FirstOrDefault();
            contacts.Remove(oldItem);
            contacts.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = contacts.Where((EContact arg) => arg.Id == id).FirstOrDefault();
            contacts.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<EContact> GetItemAsync(string id)
        {
            return await Task.FromResult(contacts.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<EContact>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(contacts);
        }
    }
}