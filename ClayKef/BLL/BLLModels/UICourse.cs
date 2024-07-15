using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLModels
{
    public class UICourse
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int NumOfMembers { get; set; }
        public int Day { get; set; }
        public float Hour { get; set; }
        public DateTime DateCours { get; set; }
        public string Ageing { get; set; }
        public int Price { get; set; }
        public string Level { get; set; }
        public List<UIMember> Members { get; set; }

        public List<int> MembersCode { get; set; }
         public string? duration { get; set; }
        public string? TypeProd { get; set; }
        public string? TechniqueProd { get; set; }
        public DateTime OpeningDate { get; set; }
        /*public UICourse(int code,string name, int num, int day, float hour, string age, int price,string level, List<UIMember> members, string type, string typeP, string techP)
        {
            this.Code = code;
            Name = name;
            NumOfMembers = num;
            Day = day;
            Hour = hour;
            Ageing = age;
            Price = price;
            Level = level;
            Members = members;
            duration = type;
            TypeProd = typeP;
            TechniqueProd = techP;
        }*/
        public UICourse()
        {
            
        }
    }
}
