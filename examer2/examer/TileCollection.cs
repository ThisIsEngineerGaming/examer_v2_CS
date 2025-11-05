using System;
using System.Collections;
using System.Collections.Generic;

namespace examer
{
    public class TileCollection : IEnumerable<Tile>
    {
        private List<Tile> tiles = new List<Tile>();

        public void Add(Tile tile)
        {
            tiles.Add(tile);
        }

        public IEnumerator<Tile> GetEnumerator()
        {
            return new TileEnumerator(tiles);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class TileEnumerator : IEnumerator<Tile>
        {
            private readonly List<Tile> tiles;
            private int index = -1;

            public TileEnumerator(List<Tile> tiles)
            {
                this.tiles = tiles;
            }

            public Tile Current => tiles[index];
            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                index++;
                return index < tiles.Count;
            }

            public void Reset()
            {
                index = -1;
            }

            public void Dispose() { }
        }
    }
}
