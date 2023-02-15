using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//Group Members: Donato Di Tullio & Seyedamirhossein Rouhi Ghodsinia

namespace ClassLibraryDataLayer
{
    public class FileHandler
    {
        private static String binFilePath = @"../../data/bike.bin";

        public static void WriteToSerializedFile(List<Bike> listOfBikes)
        {

            FileStream fs = new FileStream(binFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, listOfBikes);

            fs.Close();
        }

        public static List<Bike> ReadFromSerializedFile()
        {
            List<Bike> tempBikeList = new List<Bike>();

            if (File.Exists(binFilePath))
            {
                FileStream fs = new FileStream(binFilePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                tempBikeList = (List<Bike>)bf.Deserialize(fs);
                fs.Close();
            }
            return tempBikeList;

        }
    }
}

