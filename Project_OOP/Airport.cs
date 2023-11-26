﻿using Project_OOP.Interfaces;
using Project_OOP.Moldels.Aircrafts;

namespace Project_OOP
{
    public class Airport
    {
        public string Name { get; private set; }      // Назва
        public string Code { get; private set; }      // Код
        public GeographicLocation Location  { get; private set; }  // Місцезнаходження
        public List<Aircraft> aircrafts { get; private set; } = new List<Aircraft>();    // Список літаків

        public Airport(GeographicLocation location)
        {
            this.Location = location;
        }

        public void AddAircraft(Aircraft aircraft)
        {
            aircrafts.Add(aircraft);
        }

        public Aircraft? FindAircraft(string number)
        {
            return aircrafts.FirstOrDefault(a => a.Number == number);
        }

        public CommercialAircraft? FindCommercialAircraft(string number)
        {
            var aircraft = aircrafts.FirstOrDefault(a => a.Number == number);

            return aircraft as CommercialAircraft;
        }

        public MilitaryAircraft? FindMilitaryAircraft(string number)
        {
            var aircraft = aircrafts.FirstOrDefault(a => a.Number == number);

            return aircraft as MilitaryAircraft;
        }
    }
}
