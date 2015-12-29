﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VehicleLibrary
{
    public static class Database
    {
        private static string VehicleListFile = "VehicleList.xml";
        private static string AllIDStorageFile = "AllIDStorage.xml";

        public static void SaveVehicle(Vehicle vehicle)
        {
            List<Vehicle> allVehicles = ReadDatabase<Vehicle>(VehicleListFile);
            allVehicles.Add(vehicle);
            UpdateDatabase(VehicleListFile, allVehicles);
        }

        public static List<Vehicle> GetVehicles()
        {
            List<Vehicle> allVehicles = ReadDatabase<Vehicle>(VehicleListFile);
            return allVehicles;
        }

        public static void UpdateCurrentVehicle(Vehicle vehicle)
        {
            List<Vehicle> oldAllVehicles = GetVehicles();
            List<Vehicle> newAllVehicles = new List<Vehicle>();
            foreach(Vehicle Vehicle in oldAllVehicles)
            {
                if (vehicle.LiscensePlate == Vehicle.LiscensePlate)
                {
                    newAllVehicles.Add(vehicle);
                }
                else
                {
                    newAllVehicles.Add(Vehicle);
                }
            }
            UpdateDatabase(VehicleListFile, newAllVehicles);
        }

        public static List<int> ViewIDS()
        {
            List<int> allID = ReadDatabase<int>(AllIDStorageFile);
            if (allID.Count < 1)
            {
                UpdateIDS();
                ViewIDS();
            }
            return allID;
        }

        public static string GetNewID()
        {
            int newID = UpdateIDS();
            return newID.ToString();
        }

        private static int UpdateIDS()
        {
            List<int> allID = ReadDatabase<int>(AllIDStorageFile);
            int newID;
            if (allID.Count > 0)
            {
                int lastID = allID[allID.Count - 1];
                newID = lastID + 1;
            }
            else
            {
                newID = 1;
            }
            allID.Add(newID);
            UpdateDatabase(AllIDStorageFile, allID);
            return newID;
        }

        private static void UpdateDatabase<T>(string fileName, T list)
        {
            using (var file = new StreamWriter(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(list.GetType());
                serializer.Serialize(file, list);
                file.Flush();
            }
        }

        private static List<T> ReadDatabase<T>(string fileName)
        {
            List<T> infoList;
            try
            {
                using (var file = new StreamReader(fileName))
                {
                    XmlSerializer reader = new XmlSerializer(typeof(List<T>));
                    infoList = (List<T>)reader.Deserialize(file);
                }
            }
            catch (Exception ex) when (ex is FileNotFoundException || ex is DirectoryNotFoundException)
            {
                infoList = new List<T>();
            }
            return infoList;
        }
    }
}
