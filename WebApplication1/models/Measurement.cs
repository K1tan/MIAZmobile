﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.models
{
    //измерения пациента
    public class Measurement
    {
        public int Id { get; set; }
        public int IdPatient { get; set; } //id клиента
        public DateTime Date { get; set; } //дата измерения давления
        public string Status { get; set; }
        public int TopPressure { get; set; } //верхнее давление
        public int BottomPressure { get; set; }//нижнее давление
    }
}