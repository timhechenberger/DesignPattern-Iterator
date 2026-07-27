using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Iterator
{
    internal class PlaylistIterator : Iterator
    {
        private List<string> _playlist = new List<string>();
        private int _currentIndex = 0;

        public PlaylistIterator(List<string> playlist) 
        { 
          _playlist = playlist;
        }

        public bool hasNext() {
           return _currentIndex < _playlist.Count;
        }

        public string? next()
        {
            if (!hasNext())
            {
                return null;
            }
            else
            {
                string temp = _playlist.ElementAt(_currentIndex);
                _currentIndex++;
                return temp;
            }
        }
    }
}
