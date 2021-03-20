using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryForm
{
    // using System.Windows.Forms;
    class MemoryCard : Label
    {
        public Guid Id;
        // using System.Drawing;
        public Image Tyl;
        public Image Obrazek;

        public MemoryCard(Guid id, string tylPath, string obrazekPath)
        {
            Id = id;
            Tyl = Image.FromFile(tylPath);
            Obrazek = Image.FromFile(obrazekPath);
            // dziedziczone z label, dlatego nie jest wypisane w zmiennych
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        // zmień grafikę na obrazek tyłu, ustaw możliwość klikania na true
        public void Zakryj()
        {
            BackgroundImage = Tyl;
            Enabled = true;
        }
        // zmień grafikę na obrazek przodu, ustaw możliwość klikania na false (nie można klikać)
        public void Odkryj()
        {
            BackgroundImage = Obrazek;
            Enabled = false;
        }
    }
}
