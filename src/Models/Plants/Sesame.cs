using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sesame : IResource, ISeedProducing
    {
        private int _seedsProduced = 40;
        public string Type { get; } = "Sesame";

        public void AddResource(ISeedProducing seed)
        {
            throw new NotImplementedException();
        }

        public double Harvest () {
            return _seedsProduced;
        }

        public override string ToString () {
            return $"Sesame. Yum!";
        }
    }
}