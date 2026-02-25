using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class AktieEventArgs:EventArgs
    {
        public int NyKurs { get; }
        public int Stigning { get; }

        public AktieEventArgs(int kurs, int stigning)
        {
            this.NyKurs = kurs;
            this.Stigning= stigning;
        }

    }
}
