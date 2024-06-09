﻿namespace EcoTaxiAPI.Models.Abstrat
{
    public abstract class DbRecord
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime RecordDate { get; set; } = DateTime.Now;
    }
}
