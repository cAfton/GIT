using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
    public enum TypeOfTraining
    {
        Running,
        Swimming,
        Bicycling
    }
    public class Training
    {
        public TypeOfTraining TrainingType {  get; set; }
        public DateTime Date {  get; set; }
        public double Duration { get; set; }
        public double Distanse { get; set; }
        public int LostKkal { get; set; }

        public override string ToString()
        {
            return $"Type: {TrainingType}\n" +
                $"Date: {Date}\n" +
                $"Duration: {Duration}\n" +
                $"Distanse: {Distanse}\n" +
                $"Lost Kkal: {LostKkal}\n";
        }
    }
}
