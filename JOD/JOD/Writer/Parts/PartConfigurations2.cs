using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JOD.Writer.Parts
{
    public class PartConfigurations2
    {
        public void CreatNewPart()
        {
            string tempPath = General.tempPath;
            string dirConfigurations2 = Path.Combine(tempPath, "Configurations2");
            if (!Directory.Exists(dirConfigurations2))
            {
                Directory.CreateDirectory(dirConfigurations2);
            }
            string diraccelerator = Path.Combine(dirConfigurations2, "accelerator");
            if (!Directory.Exists(diraccelerator))
            {
                Directory.CreateDirectory(diraccelerator);
            }
            string dirfloater = Path.Combine(dirConfigurations2, "floater");
            if (!Directory.Exists(dirfloater))
            {
                Directory.CreateDirectory(dirfloater);
            }
            string dirimages = Path.Combine(dirConfigurations2, "images");
            if (!Directory.Exists(dirimages))
            {
                Directory.CreateDirectory(dirimages);
            }
            string dirBitmaps = Path.Combine(dirimages, "Bitmaps");
            if (!Directory.Exists(dirBitmaps))
            {
                Directory.CreateDirectory(dirBitmaps);
            }
            string dirmenubar = Path.Combine(dirConfigurations2, "menubar");
            if (!Directory.Exists(dirmenubar))
            {
                Directory.CreateDirectory(dirmenubar);
            }
            string dirpopupmenu = Path.Combine(dirConfigurations2, "popupmenu");
            if (!Directory.Exists(dirpopupmenu))
            {
                Directory.CreateDirectory(dirpopupmenu);
            }
            string dirprogressbar = Path.Combine(dirConfigurations2, "progressbar");
            if (!Directory.Exists(dirprogressbar))
            {
                Directory.CreateDirectory(dirprogressbar);
            }
            string dirstatusbar = Path.Combine(dirConfigurations2, "statusbar");
            if (!Directory.Exists(dirstatusbar))
            {
                Directory.CreateDirectory(dirstatusbar);
            }
            string dirtoolbar = Path.Combine(dirConfigurations2, "toolbar");
            if (!Directory.Exists(dirtoolbar))
            {
                Directory.CreateDirectory(dirtoolbar);
            }
            string dirtoolpanel = Path.Combine(dirConfigurations2, "toolpanel");
            if (!Directory.Exists(dirtoolpanel))
            {
                Directory.CreateDirectory(dirtoolpanel);
            }
        }
    }
}
