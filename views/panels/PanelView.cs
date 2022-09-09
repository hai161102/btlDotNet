using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCotrol.views.panels
{
    internal class PanelView : Panel
    {
        private int panelX;
        private int panelY;
        private int panelWidth;
        private int panelHeight;
        private List<Control> listChildView;

        public int PanelX { get => panelX; set => panelX = value;        
        }
        public int PanelY { get => panelY; set => panelY = value; }
        public int PanelWidth { get => panelWidth; set => panelWidth = value; }
        public int PanelHeight { get => panelHeight; set => panelHeight = value; }
        public List<Control> ListChildView { get => listChildView; set => listChildView = value; }

        public PanelView()
        {
            
            this.panelX = 0;
            this.panelY = 0;
            this.panelHeight = 0;
            this.panelWidth = 0;
            this.listChildView = new List<Control>();
            this.SetBounds(panelX, panelY, panelWidth, panelHeight);
        }
        public PanelView(int x, int y, int width, int heigt)
        {
            this.panelX = x;
            this.panelY = y;
            this.panelWidth = width;
            this.panelHeight = heigt;
            this.listChildView = new List<Control>();
            this.SetBounds(panelX, panelY, panelWidth, panelHeight);
        }
        public PanelView(int x, int y, int width, int heigt, List<Control> listChildView)
        {
            this.panelX = x;
            this.panelY = y;
            this.panelWidth = width;
            this.panelHeight = heigt;
            this.listChildView = listChildView;
            this.SetBounds(panelX, panelY, panelWidth, panelHeight);
        }


        public void addChillView(Control value)
        {
            this.Controls.Add(value);
        }

        public void addAll(List<Control> list)
        {
            list.ForEach(control => this.Controls.Add(control));
        }
        public void clearChildView()
        {
            this.Controls.Clear();
            this.listChildView.Clear();
        }

        
    }
}
