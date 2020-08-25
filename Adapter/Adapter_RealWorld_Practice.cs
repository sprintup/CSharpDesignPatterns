﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter_RealWorld_Practice
    {
        public static void Run()
        {
            Console.WriteLine("\n Adapter Real World Practice");
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
        }

        class Compound
        {
            protected string _chemical;
            protected float _boilingPoint;
            protected float _meltingPoint;
            protected double _molecularWeight;
            protected string _molecularFormula;

            public Compound(string chemical)
            {
                this._chemical = chemical;
            }

            public virtual void Display()
            {
                Console.WriteLine("\n Compound: {0} ----", _chemical);
            }
        }

        class RichCompound : Compound
        {
            private ChemicalDatabank _bank;

            public RichCompound(string name) : base(name) { }

            public override void Display()
            {
                _bank = new ChemicalDatabank();

                _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
                _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
                _molecularWeight = _bank.GetMolecularWeight(_chemical);
                _molecularFormula = _bank.GetMolecularStructure(_chemical);

                base.Display();
                Console.WriteLine(" Formula: {0}", _molecularFormula);
                Console.WriteLine(" Weight: {0}", _molecularWeight);
                Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
                Console.WriteLine(" Boiling Pt: {0}", _boilingPoint);
            }
        }

        class ChemicalDatabank
        {
            public float GetCriticalPoint(string compound, string point)
            {
                if (point == "M")
                {
                    switch (compound.ToLower())
                    {
                        case "water": return 0.0f;
                        case "benzene": return 80.1f;
                        case "ethanol": return -114.1f;
                        default: return 0f;
                    }
                } 
                else
                {
                    switch (compound.ToLower())
                    {
                        case "water": return 100.0f;
                        case "benzene": return 80.1f;
                        case "ethanol": return 78.3f;
                        default: return 0f;
                    }
                }
            }
            public string GetMolecularStructure(string compound)
            {
                switch (compound.ToLower())
                {
                    case "water": return "H20";
                    case "benzene": return "C6H6";
                    case "ethanol": return "C2H5OH";
                    default: return "";
                }
            }
            public double GetMolecularWeight(string compound)
            {
                switch (compound.ToLower())
                {
                    case "water": return 18.015;
                    case "benzene": return 78.1134;
                    case "ethanol": return 46.0688;
                    default: return 0d;
                }
            }
        }
    }
}
