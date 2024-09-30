using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab_09
{
    [Serializable]
    [DataContract]
    public class Player : ISerializable
    {
        [DataMember]
        private string userName;
        [DataMember]
        private double reward;
        [DataMember]
        public string UserName { get => userName; set => userName = value; }
        [DataMember]
        public double Reward { get => reward; set => reward = value; }

        public Player()
        {
           
        }

        public void Spend(double amount)
        {
            if (amount > Reward)
            {
                throw new Exception("Điểm của bạn không đủ để trồng cây");
            }
            Reward -= amount;
        }

        public void Earn(double amount)
        {
            Reward += amount;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name",UserName);
            info.AddValue("Reward",Reward);
        }
        public Player(SerializationInfo info, StreamingContext context)
        {
            UserName = info.GetString("Name");
            Reward = info.GetDouble("Reward");
        }
        public override string ToString()
        {
            return $"Xin chào {userName}! Điểm thưởng hiện tại của bạn là: {reward}";
        }
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
