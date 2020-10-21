using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace RAmsol
{
    public partial class Form1 : Form
    {
        int gamemode = 70;
        bullet[] changable_item = new bullet[2];
        bullet[] changable_item_backup = new bullet[0];
        item[] static_item = new item[0];
        item[] static_item_backup = new item[0];
        Size SP = new Size(20, 20);
        Size SB = new Size(20, 5);
        int[,] graph = new int[20,20];
        int[,] graph_backup = new int[15, 20];
        PictureBox platform = new PictureBox();
        PictureBox base1 = new PictureBox();
        Pen penB = new Pen(Color.Black, 3);
        SolidBrush SB1 = new SolidBrush(Color.BurlyWood);
        SolidBrush SBClear = new SolidBrush(SystemColors.Control);
        SolidBrush SBdeath = new SolidBrush(Color.Red);
        SolidBrush SBJump = new SolidBrush(Color.Green);
        SolidBrush SBtpStart = new SolidBrush(Color.Yellow);
        SolidBrush SBtpEnd = new SolidBrush(Color.Blue);
        Point[] item_Spawn = new Point[6];
        PictureBox[] pic_Bank = new PictureBox[10];
        // player
        int p1x = 2;
        int p1y = 2;
        int xor = 0;
        int yor = 0;
        bool right1 = false;
        bool left1 = false;
        int momentum1 = 0;
        int speed1 = 2;
        bool gravaty1 = true;
        bool jump = false;
        bool selected = false;
        int p1c = 9;

        public class item
        {
            public SolidBrush pen;
            public Rectangle rec;

            public item(SolidBrush p1, Rectangle rect)
            {
                pen = p1;
                rec = rect;
            }
        }
        public class bullet
        {
            public SolidBrush pen;
            public int object_class;
            public int locationX;
            public int locationY;

            public bullet(SolidBrush p1, int classe, int locationH, int locationV)
            {
                pen = p1;
                object_class = classe;
                locationX = locationH;
                locationY = locationV;
            }
        }

        public void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(penB, 140, 2, 400, 400);
            e.Graphics.DrawRectangle(penB, 5, 410, 560, 30);
            e.Graphics.DrawRectangle(new Pen(Color.Red, 3), 20, 2, 90, 90);
            e.Graphics.DrawRectangle(new Pen(Color.Blue, 3), 20, 105, 90, 90);
            e.Graphics.DrawRectangle(new Pen(Color.Red, 3), 20, 209, 90, 90);
            e.Graphics.DrawRectangle(new Pen(Color.Green, 3), 20, 312, 90, 90);
        }
        public void Form2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), 0, 2, 40, 398);
            e.Graphics.FillRectangle(new SolidBrush(Color.LightGreen), 380, 2, 20, 398);
            for (int i = 0; i < static_item.Length; i++)
            { 
                item item1 = static_item[i];
                e.Graphics.FillRectangle(item1.pen, item1.rec);
            }
        }
        public void bullet_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            for (int i = 0; i < changable_item.Length; i++)
            {
                bullet item1 = changable_item[i];
                e.Graphics.FillRectangle(item1.pen, new Rectangle(new Point(item1.locationX, item1.locationY - 5), SB));
            }
        }
        public Form1()
        {
            InitializeComponent();
            platform.ClientSize = new Size (600, 500);
            base1.Location = new Point(140, 2); 
            base1.ClientSize = new Size(401, 401);
        }

        public void reset()
        {
            Point origin = new Point(1000, 1000);
            for (int i=0; i<9; i++)
            {
                pic_Bank[i].Location = origin;
                pic_Bank[i].Visible = true;
            }
            p1x = 2;
            p1y = 2;
            xor = 0;
            yor = 0;
            speed1 = 2;
        }
        public void reset_Size()
        {
            Size small = new Size(20, 20);
            Size big = new Size(90, 90);
            if (pic_Bank[0].Size == small)
            {
                for (int i = 0; i < 9; i++)
                {
                    pic_Bank[i].Size = big;
                }
            }
            else
            {
                for (int i = 0; i < 9; i++)
                {
                    pic_Bank[i].Size = small;
                }
            }
        }

        public void playmode()
        {
            bullet[] temp_item = new bullet[0];
            for (int i=0; i<changable_item.Length; i++)
            {
                bullet now = changable_item[i];
                int length = temp_item.Length;
                int id = now.object_class;
                int Xof = now.locationX;
                int Yof = now.locationY;
                // if the cannon is ready to fire
                // 1 is cannon, 2 is bullet, 3 is trail
                if (Xof > 0)
                {
                    int ree = (Xof - 20) / 20;
                    if (id == 1)
                    {
                        Array.Resize(ref temp_item, length + 1);
                        temp_item[length] = new bullet(SBdeath, 1, Xof, Yof);

                        if (gamemode % 6 == 0)
                        {
                            Array.Resize(ref temp_item, length + 2);
                            temp_item[length + 1] = new bullet(SBdeath, 2, Xof - 20, Yof);
                        }
                    }
                    // if it is a bullet
                    else if (id == 2)
                    {
                        int g = graph[(Yof - 20) / 20, ree];
                        if (g == 0 && Xof/20 > 2)
                        {
                            Array.Resize(ref temp_item, length + 1);
                            //temp_item[length + 1] = new bullet(SBdeath, 2, now.locationX - 20, now.locationY);
                            temp_item[length] = new bullet(SBdeath, 2, Xof - 20, Yof);
                            graph[(Yof / 20) - 1, ree] = 3;
                            graph[(Yof / 20) - 1, ree + 1] = 0;
                        }
                        else if (ree > 1)
                        {
                            graph[(Yof / 20) - 1, ree + 1] = 0;
                        }
                        else
                        {
                            graph[(Yof / 20) - 1, ree + 1] = 0;
                            graph[(Yof / 20) - 1, ree] = 0;
                        }
                    }
                    else if (id == 4)
                    {
                        Array.Resize(ref temp_item, length + 1);
                        temp_item[length] = new bullet(SBdeath, 4, Xof, Yof);
                        int g = ree;
                        if (gamemode % 10 == 0)
                        {
                            while (g > 1)
                            {
                                Array.Resize(ref temp_item, length + 2 + ree - g);
                                temp_item[length + 1 + ree - g] = new bullet(SBdeath, 3, (Xof - 20) - (ree - g) * 20, Yof);
                                graph[(Yof / 20) - 1, ree - (ree - g)] = 3;
                                g--;
                            }
                        }
                    }
                    else
                    {
                        graph[(Yof / 20) - 1, ree + 1] = 0;
                    }
                }
            }
            picupdate.Location = new Point(0, 0);
            picupdate.Location = new Point(-1000, -1000);
            changable_item = temp_item;
        }
        
        public int randomize()
        {
            Random rnd = new Random();
            int k = rnd.Next(0, 9);
            return k;
        }

        public void updatelocation()
        {
            gravaty1 = true;
            int locX = (p1x + 7) / 20;
            int locY = p1y / 20;
            int k = graph[locY, locX];
            if (k == 1)
            {
                gravaty1 = false;
            }
            else if (k == 2)
            {
                p1x = 2;
                p1y = 2;
            }
            else if (k == 3)
            {
                speed1 = 0;
                gravaty1 = false;
            }
            else if (k == 4)
            {
                momentum1 = -17;
                p1y = p1y - 5;
            }
            else if (k == 5)
            {
                p1y = 50;
            }

            if (gravaty1 == true)
            {
                if (momentum1 < 7)
                {
                    momentum1++;
                    p1y = p1y + momentum1;
                }
                else
                {
                    p1y = p1y + momentum1;
                }
            }
            else
            {
                p1y = locY * 20;
                if(jump == true && speed1 == 2)
                {
                    momentum1 = -12;
                    p1y = p1y - 5;
                }
            }
            if (left1)
            {
                p1x = p1x - speed1;
            }
            else if (right1)
            {
                p1x = p1x + speed1;
            }

            if (p1x < 0)
            {
                p1x = 0;
            }
            else if (p1x > 385)
            {
                lblError.Text = "First Place!!";
                speed1 = 0;
            }
            PicSelect1.Location = new Point(p1x + 140, p1y);
            // other player will be implemented later
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            item[] temp_item = new item[16];
            picupdate.Size = new Size(1000, 1000);
            temp_item[0] = new item(SB1, new Rectangle(new Point(0, 300), SP));
            temp_item[1] = new item(SB1, new Rectangle(new Point(20, 300), SP));
            temp_item[2] = new item(SBdeath, new Rectangle(new Point(40, 300), SP));
            temp_item[3] = new item(SB1, new Rectangle(new Point(60, 300), SP));
            temp_item[4] = new item(SBJump, new Rectangle(new Point(100, 300), SP));
            temp_item[5] = new item(SBtpStart, new Rectangle(new Point(180, 300), SP));
            temp_item[6] = new item(SBtpEnd, new Rectangle(new Point(180, 60), SP));
            temp_item[7] = new item(SB1, new Rectangle(new Point(80, 300), SP));
            temp_item[8] = new item(SB1, new Rectangle(new Point(120, 300), SP));
            temp_item[9] = new item(SB1, new Rectangle(new Point(140, 300), SP));
            temp_item[10] = new item(SB1, new Rectangle(new Point(160, 300), SP));
            temp_item[11] = new item(SBdeath, new Rectangle(new Point(140, 280), SP));
            temp_item[12] = new item(SBdeath, new Rectangle(new Point(140, 260), SP));
            temp_item[13] = new item(SBdeath, new Rectangle(new Point(140, 240), SP));
            temp_item[14] = new item(SB1, new Rectangle(new Point(180, 120), SP));
            temp_item[15] = new item(SB1, new Rectangle(new Point(200, 120), SP));
            item_Spawn[0] = new Point(200, 100);
            item_Spawn[1] = new Point(300, 100);
            item_Spawn[2] = new Point(400, 100);
            item_Spawn[3] = new Point(200, 200);
            item_Spawn[4] = new Point(300, 200);
            item_Spawn[5] = new Point(400, 200);
            pic_Bank[0] = picPlatformS;
            pic_Bank[1] = picPlatformL;
            pic_Bank[2] = picCoin;
            pic_Bank[3] = picCannon;
            pic_Bank[4] = picDemo;
            pic_Bank[5] = picJumpad;
            pic_Bank[6] = picLazer;
            pic_Bank[7] = picPortal;
            pic_Bank[8] = picTrap;
            pic_Bank[9] = picupdate;
            changable_item[0] = new bullet(SB1, 1, 300, 280);
            changable_item[1] = new bullet(SB1, 4, 340, 220);
            changable_item_backup = changable_item;
            graph[14, 0] = 1; //1 = normal tile
            graph[14, 1] = 1;
            graph[14, 2] = 3; //3 = death trap
            graph[14, 3] = 1;
            graph[14, 4] = 1;
            graph[14, 5] = 4; //4 = bounce pad
            graph[14, 6] = 1;
            graph[14, 7] = 1;
            graph[14, 8] = 1;
            graph[14, 9] = 5; //5 = teleporter 
            graph[13, 7] = 3;
            graph[12, 7] = 3;
            graph[11, 7] = 3;
            graph[5, 9] = 1;
            graph[5, 10] = 1;
            graph[19, 19] = 1;
            for (int i=0; i<19; i++)
            {
                graph[19,i] = 2; //2 = reset home
            }
            static_item = temp_item;
            static_item_backup = temp_item;
            graph_backup = graph;
            base1.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            base1.Paint += new System.Windows.Forms.PaintEventHandler(this.bullet_Paint);
            this.Controls.Add(base1);
            platform.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Controls.Add(platform);
            reset();
            updatelocation();
        }
        //
        //TIMERS
        //
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            //base1.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            if (gamemode > 20)
            {
                pgb1.Value = (500 - (gamemode - 20) * 10) / 5;
                playmode();
                base1.Paint += new System.Windows.Forms.PaintEventHandler(this.bullet_Paint);
            }
            else if (gamemode == 20)
            {
                tmrPlayer.Enabled = false;
                graph = graph_backup;
                static_item = static_item_backup;
                reset();
                for (int i = 0; i < 6; i++)
                {
                    pic_Bank[randomize()].Location = item_Spawn[i];
                    Thread.Sleep(100);
                }
                tmrSelect.Enabled = true;
            }
            else if (gamemode == 10)
            {
                reset();
                reset_Size();
                tmrSelect.Enabled = false;
                tmrBuild.Enabled = true;
            }
            else if (gamemode == 0)
            {
                graph_backup = graph;
                static_item_backup = static_item;
                reset();
                reset_Size();
                p1c = 9;
                selected = false;
                gamemode = 69;
                tmrBuild.Enabled = false;
                tmrPlayer.Enabled = true;
                Thread.Sleep(50);
            }
            gamemode--;

        }

        private void tmrPlayer_Tick(object sender, EventArgs e)
        {
            updatelocation(); 
        }

        //
        //Key events
        //

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                right1 = true;
            }
            if (e.KeyCode == Keys.A)
            {
                left1 = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                jump = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jump = false;
            }
            if (e.KeyCode == Keys.D)
            {
                right1 = false;
            }
            if (e.KeyCode == Keys.A)
            {
                left1 = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            reset();
            for (int i = 0; i < 6; i++)
            {
                pic_Bank[randomize()].Location = item_Spawn[i];
                Thread.Sleep(100);
            }
        }

        private void tmrSelect_Tick(object sender, EventArgs e)
        {
            pgb1.Value = 200 - gamemode * 10;
            if (gamemode > 15)
            {
                Cursor.Position = new Point(0, 0);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            gamemode = 21;
        }
        private void tmrBuild_Tick(object sender, EventArgs e)
        {
            pgb1.Value = 100 - gamemode * 10;
            Point g = this.PointToClient(Cursor.Position);
            xor = (g.X) / 20;
            yor = (g.Y) / 20;
            pic_Bank[p1c].Location = new Point(xor * 20, yor * 20);
        }
        public bool run_error()
        {
            Point g = this.PointToClient(Cursor.Position);
            xor = ((g.X) / 20) - 7;
            yor = (g.Y) / 20;
            label2.Text = xor.ToString() +" " + yor.ToString();
            if (p1c == 0)
            {
                if (xor < 1 || xor > 16 || yor < 5 || yor > 19)
                {
                    return true;
                }
                return false;
            }
            else if (p1c == 1)
            {
                if (xor < 1 || xor > 19 || yor < 7 || yor > 16)
                {
                    return true;
                }
                return false;
            }
            else if (p1c == 4)
            {
                if (xor < 1 || xor > 19 || yor < 5 || yor > 19)
                {
                    return true;
                }
                return false;
            }
            else if (p1c == 5)
            {
                if (xor < 1 || xor > 19 || yor < 8 || yor > 19)
                {
                    return true;
                }
                return false;
            }
            else if (xor < 3 || xor > 19 || yor < 1 || yor > 19)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void place(int id, int Vlength, int Hlength, SolidBrush SBT)
        {
            int tot = (Vlength * Hlength);
            int r = 0;
            Array.Resize(ref static_item, static_item.Length + tot);
            for (int i = 0; i< Vlength; i++)
            {
                for(int k=0; k< Hlength; k++)
                {
                    graph[yor - 1 - i, xor + k] = id;
                    static_item[static_item.Length - r - 1] = new item(SBT, new Rectangle(new Point((xor + k) * 20, (yor - i) * 20),  SP));
                    r++;
                }
            }
            base1.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            picupdate.Location = new Point(0, 0);
            picupdate.Location = new Point(-1000, -1000);
            Thread.Sleep(30);
        }

        private void picPlatformS_Click(object sender, EventArgs e)
        {
            if (selected == false)
            {
                p1c = 0;
                picPlatformS.Visible = false;
                selected = true;
            }
            else if (run_error())
            {
                lblError.Text = "Invalid Placement!";
            }
            else
            {
                place(1, 1, 3, SB1);
                picPlatformS.Visible = false;
            }
        }

        private void picPlatformL_Click(object sender, EventArgs e)
        {
            if (selected == false)
            {
                p1c = 1;
                picPlatformL.Visible = false;
                selected = true;
            }
            else if (run_error())
            {
                lblError.Text = "Invalid Placement!";
            }
            else
            {
                place(1, 3, 1, SB1);
                picPlatformL.Visible = false;
            }
        }
        private void picJumpad_Click(object sender, EventArgs e)
        {
            if (selected == false)
            {
                p1c = 5;
                picJumpad.Visible = false;
                selected = true;
            }
            else if (run_error())
            {
                lblError.Text = "Invalid Placement!";
            }
            else
            {
                place(4, 1, 1, SBJump);
                picJumpad.Visible = false;
            }
        }
        private void picTrap_Click(object sender, EventArgs e)
        {
            if (selected == false)
            {
                p1c = 8;
                picTrap.Visible = false;
                selected = true;
            }
            else if (run_error())
            {
                lblError.Text = "Invalid Placement!";
            }
            else
            {
                place(3, 1, 1, SBdeath);
                picTrap.Visible = false;
            }
        }
        private void picCannon_Click(object sender, EventArgs e)
        {
            if (selected == false)
            {
                p1c = 3;
                picCannon.Visible = false;
                selected = true;
            }
            else if (run_error())
            {
                lblError.Text = "Invalid Placement!";
            }
            else
            {
                Array.Resize(ref changable_item, changable_item.Length + 1);
                changable_item[changable_item.Length - 1] = new bullet(SB1, 1, xor * 20, yor * 20);
                picCannon.Visible = false;
                base1.Paint += new System.Windows.Forms.PaintEventHandler(this.bullet_Paint);
            }
        }
        private void picCoin_Click(object sender, EventArgs e)
        {
            p1c = 3;
            picCoin.Visible = false;
            selected = true;
        }
        private void picDemo_Click(object sender, EventArgs e)
        {
            if (selected == false)
            {
                p1c = 4;
                picDemo.Visible = false;
                selected = true;
            }
            else if (run_error())
            {
                lblError.Text = "Invalid Placement!";
            }
            else
            {
                picDemo.Visible = false;
                place(0, 3, 3, SBClear);
            }
        }
        private void picLazer_Click(object sender, EventArgs e)
        {
            if (selected == false)
            {
                p1c = 6;
                picLazer.Visible = false;
                selected = true;
            }
            else if (run_error())
            {
                lblError.Text = "Invalid Placement!";
            }
            else
            {
                Array.Resize(ref changable_item, changable_item.Length + 1);
                changable_item[changable_item.Length - 1] = new bullet(SB1, 4, xor * 20, yor * 20);
                picLazer.Visible = false;
                base1.Paint += new System.Windows.Forms.PaintEventHandler(this.bullet_Paint);
            }
        }
        private void picPortal_Click(object sender, EventArgs e)
        {
            if (selected == false)
            {
                p1c = 7;
                picPortal.Visible = false;
                selected = true;
            }
            else if (run_error())
            {
                lblError.Text = "Invalid Placement!";
            }
            else
            {
                picPortal.Visible = false;
                place(5, 1, 1, SBtpStart);
                Thread.Sleep(20);
                Array.Resize(ref static_item, static_item.Length + 1);
                static_item[static_item.Length - 1] = new item(SBtpEnd, new Rectangle(new Point(xor*20, 60), SP));
                base1.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
                picupdate.Location = new Point(0, 0);
                picupdate.Location = new Point(-1000, -1000);
            }
        }

        private void lblSubmit_Click(object sender, EventArgs e)
        {
            reset();
            gamemode = 70;
            lblSubmit.Visible = false;
            hSB2.Visible = false;
            hSB1.Visible = false;
            //ngserve
            //

            //
        }

        private void hSB1_Scroll(object sender, ScrollEventArgs e)
        {
            lblSubmit.Text = "Click to host@ freq " + hSB1.Value.ToString() + "-" + hSB2.Value.ToString()+ ", 0 - offline";
        }

        private void hSB2_Scroll(object sender, ScrollEventArgs e)
        {
            lblSubmit.Text = "Click to host@ freq " + hSB1.Value.ToString() + "-" + hSB2.Value.ToString() + ", 0 - offline";
        }
    }
}
