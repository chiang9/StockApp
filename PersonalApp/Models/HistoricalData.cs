using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/*
{
date: "2017-01-03",
open: 62.79,
high: 62.84,
low: 62.125,
close: 62.58,
volume: 20694101,
unadjustedVolume: 20694101,
change: 0.44,
changePercent: 0.708,
vwap: 62.4495,
label: "Jan 3, 17",
changeOverTime: 0
}
*/
namespace PersonalApp.Models
{
    public class HistoricalData
    {
        public string date { get; set; }
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double close { get; set; }
        public int volume { get; set; }
        public int unadjustedVolume { get; set; }
        public double change { get; set; }
        public double changePercent { get; set; }
        public double vwap { get; set; }
        public string label { get; set; }
        public double changeOverTime { get; set; }
    }
}