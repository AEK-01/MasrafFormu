using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Makbuz:IEntity
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string NameOfTheAuthor { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public double TotalCost { get; set; }

    }


} 
