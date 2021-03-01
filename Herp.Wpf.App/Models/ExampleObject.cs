using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using Herp.Wpf.App.Converter;
using PropertyTools;
using PropertyTools.DataAnnotations;

namespace Herp.Wpf.App.Models
{
    public class ExampleObject : Observable
    {
        private static readonly Random r = new Random(0);
        private bool _boolean;
        private Color _color;
        private DateTime _dateTime;
        private Fruit _fruit;
        private int _integer;
        private Mass _mass;
        private double _number;
        private int _readOnlyInteger;
        private string _s;
        private string _selector;

        public bool Boolean
        {
            get => _boolean;

            set
            {
                if (SetValue(ref _boolean, value)) RaisePropertyChanged("ReadOnlyBoolean");
            }
        }

        public bool ReadOnlyBoolean => _boolean;

        public Fruit Fruit
        {
            get => _fruit;

            set => SetValue(ref _fruit, value);
        }

        public IEnumerable<Fruit> Fruits => Enum.GetValues(typeof(Fruit)).Cast<Fruit>();

        public double Number
        {
            get => _number;

            set => SetValue(ref _number, value);
        }

        public int Integer
        {
            get => _integer;

            set => SetValue(ref _integer, value);
        }

        [ReadOnly(true)]
        public int ReadOnlyInteger
        {
            get => _readOnlyInteger;

            set => SetValue(ref _readOnlyInteger, value);
        }

        public DateTime DateTime
        {
            get => _dateTime;

            set => SetValue(ref _dateTime, value);
        }

        public string String
        {
            get => _s;

            set
            {
                if (SetValue(ref _s, value)) RaisePropertyChanged(nameof(ReadOnlyString));
            }
        }

        public string ReadOnlyString => _s != null ? "L=" + _s.Length : null;

        public Color Color
        {
            get => _color;

            set => SetValue(ref _color, value);
        }

        public Mass Mass
        {
            get => _mass;

            set => SetValue(ref _mass, value);
        }

        [ItemsSourceProperty("Items")]
        public string Selector
        {
            get => _selector;

            set => SetValue(ref _selector, value);
        }

        [Browsable(false)] public IEnumerable<string> Items => StandardCollections.Cities;

        public static ExampleObject CreateRandom()
        {
            return new ExampleObject
            {
                Boolean = r.Next(2) == 0,
                DateTime = DateTime.Now.AddDays(r.Next(365)),
                Color =
                    Color.FromArgb(
                        (byte) r.Next(255),
                        (byte) r.Next(255),
                        (byte) r.Next(255),
                        (byte) r.Next(255)),
                Number = r.Next(),
                Fruit = (Fruit) r.Next(5),
                Integer = r.Next(1024),
                Selector = null,
                String = StandardCollections.GenerateName()
            };
        }

        public override string ToString()
        {
            return String;
        }
    }
}