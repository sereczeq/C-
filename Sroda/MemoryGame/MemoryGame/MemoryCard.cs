﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    // using System.Windows.Forms; - na górze kodu
    class MemoryCard : Label
    {
        public Guid Id;
        // using System.Drawing; - na górze kodu
        public Image Tyl;
        public Image Obrazek;

        public MemoryCard(Guid id, string tylPath, string obrazekPath)
        {
            Id = id;
            Tyl = Image.FromFile(tylPath);
            Obrazek = Image.FromFile(obrazekPath);
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void Zakryj()
        {
            BackgroundImage = Tyl;
            Enabled = true;
        }
        public void Odkryj()
        {
            BackgroundImage = Obrazek;
            Enabled = false;
        }
    }
}
