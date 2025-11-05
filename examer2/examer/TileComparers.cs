using System;
using System.Collections.Generic;

namespace examer
{
    public class Tile
    {
        public string Suit { get; set; }
        public int Value { get; set; }
    }

    public class TileComparers
    {
        public class SuitComparer : IComparer<Tile>
        {
            public int Compare(Tile x, Tile y)
            {
                if (x == null || y == null) throw new ArgumentNullException();
                int suitCompare = string.Compare(x.Suit, y.Suit, StringComparison.OrdinalIgnoreCase);
                if (suitCompare != 0) return suitCompare;
                return x.Value.CompareTo(y.Value);
            }
        }

        public class ValueComparer : IComparer<Tile>
        {
            public int Compare(Tile x, Tile y)
            {
                if (x == null || y == null) throw new ArgumentNullException();
                return x.Value.CompareTo(y.Value);
            }
        }
    }
}
