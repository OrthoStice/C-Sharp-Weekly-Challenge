using System;
using System.Collections.Generic;
using Newtonsoft.Json; //Build the project to cause Visual Studio to load this external NuGet package.


namespace CodeLou.CSharp.Week3.Challenge
{
    public class AppointmentRepository : ICalendarItemRepository<Appointment>
    {
        private bool StartDateTime;

        //Info: This is a neat type that allows you to lookup items by ID, be careful not to ask for an item that isn't there.
        private readonly Dictionary<int, Appointment> _dictionary;

        public AppointmentRepository()
        {
            _dictionary = new Dictionary<int, Appointment>();
        }

        public Appointment Create()
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

            var appointment = new Appointment();
            appointment.Id = nextAvailableId;
            _dictionary.Add(nextAvailableId, new Appointment());

            return appointment;
        }

        public void Delete(Appointment item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> FindByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Appointment FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Appointment> GetAllItems()
        {
            throw new NotImplementedException();
        }
        // Appointments need to be assigned a start date and time, an end date and time, and a location.
        public void LoadFromJson(string json)
        {
            throw new NotImplementedException();
        }

        public string ToJson()
        {
            throw new NotImplementedException();
        }

        public Appointment Update(Appointment item)
        {
            throw new NotImplementedException();
        }
    }
}
        //Callenge: Are you finding that you are writing this same code many times? Is there a better way? 
        //Could you use inheritance?

