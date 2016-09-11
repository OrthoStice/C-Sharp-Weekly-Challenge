using System;
using System.Collections.Generic;
using Newtonsoft.Json; //Build the project to cause Visual Studio to load this external NuGet package.

namespace CodeLou.CSharp.Week3.Challenge
{
    public class MeetingRepository : ICalendarItemRepository<Meeting>
    {
        //Info: This is a neat type that allows you to lookup items by ID, be careful not to ask for an item that isn't there.
        private readonly Dictionary<int, Meeting> _dictionary;

        public MeetingRepository()
        {
            _dictionary = new Dictionary<int, Meeting>();
        }

        public Meeting Create()
        {
            //Challenge: Can you find a more efficient way to do this?
            var nextAvailableId = 0;
            foreach (var currentId in _dictionary.Keys)
            {
                if (nextAvailableId > currentId)
                    continue;
                if (nextAvailableId < currentId)
                    break;

                nextAvailableId++;
            }

            var meeting = new Meeting();
            meeting.Id = nextAvailableId;
            _dictionary.Add(nextAvailableId, new Meeting());

            return meeting;
        }

        public Meeting FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Meeting Update(Meeting item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Meeting item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Meeting> FindByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Meeting> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public string ToJson()
        {
            throw new NotImplementedException();
        }

        public void LoadFromJson(string json)
        {
            throw new NotImplementedException();
        }
    }
}

        //Callenge: Are you finding that you are writing this same code many times? Is there a better way? 
        //Could you use inheritance?
	