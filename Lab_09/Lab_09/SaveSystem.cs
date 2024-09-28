using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_09
{
    public class SaveSystem
    {
        //public static void SavePlayerData(Player data, string filePath)
        //{
        //    DataContractSerializer serializer = new DataContractSerializer(typeof(Player));
        //    using (FileStream stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        serializer.WriteObject(stream, data);
        //    }
        //}
        //public static Player LoadPlayerData(string filePath)
        //{
        //    if (File.Exists(filePath))
        //    {
        //        DataContractSerializer serializer = new DataContractSerializer(typeof(Player));

        //        using (FileStream stream = new FileStream(filePath, FileMode.Open))
        //        {
        //            return (Player)serializer.ReadObject(stream);
        //        }
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        public static void SaveBinaryData(Player player, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, player);
            }
        }

        public static Player LoadBinaryData(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Player)formatter.Deserialize(fs);
            }
        }
    }
}
