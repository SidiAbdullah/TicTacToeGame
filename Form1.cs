using System.Drawing.Design;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        PictureBox[] pctBoxes;
        Image imgX, imgO, imgMark;
        public Form1()
        {
            InitializeComponent();
            pctBoxes = new PictureBox[] { pct1, pct2, pct3, pct4, pct5, pct6, pct7, pct8, pct9 };
            imgX = Image.FromFile(@"C:\Users\hp\OneDrive\Images\xTicTacToe.png");
            imgO = Image.FromFile(@"C:\Users\hp\OneDrive\Images\oTicTacToe.png");
            imgMark = Image.FromFile(@"C:\Users\hp\OneDrive\Images\question_mark_PNG.png");

            ResetGame();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 5);

            e.Graphics.DrawLine(pen, 300, 100, 300, 400);
            e.Graphics.DrawLine(pen, 400, 100, 400, 400);
            e.Graphics.DrawLine(pen, 200, 200, 500, 200);
            e.Graphics.DrawLine(pen, 200, 300, 500, 300);
        }

        string currentPlayer = "x";
        Image fillPictureBox(PictureBox pct)
        {
            if (currentPlayer.ToLower() == "x")
            {
                pct.Tag = currentPlayer;
                currentPlayer = "o";
                return imgX;
            }
            else
            {
                pct.Tag = currentPlayer;
                currentPlayer = "x";
                return imgO;
            }
        }

        bool isSameTag(PictureBox x, PictureBox y, PictureBox z)
        {
            return (x.Tag != null && y.Tag != null && z.Tag != null &&
                    x.Tag.ToString() == y.Tag.ToString() &&
                    y.Tag.ToString() == z.Tag.ToString());
        }

        bool IsAllPctBoxesChecked()
        {
            foreach(PictureBox pct in pctBoxes)
            {
                if (pct.Tag == null) return false;
            }
            return true;
        }
        void DisableAllBoxes()
        {
            foreach (PictureBox box in pctBoxes)
                box.Enabled = false;
        }

        void isWin()
        {
            string winner = null;

            if (isSameTag(pct1, pct2, pct3)) winner = pct1.Tag.ToString();
            else if (isSameTag(pct1, pct5, pct9)) winner = pct1.Tag.ToString();
            else if (isSameTag(pct1, pct4, pct7)) winner = pct1.Tag.ToString();
            else if (isSameTag(pct2, pct5, pct8)) winner = pct2.Tag.ToString();
            else if (isSameTag(pct3, pct6, pct9)) winner = pct3.Tag.ToString();
            else if (isSameTag(pct3, pct5, pct7)) winner = pct3.Tag.ToString();
            else if (isSameTag(pct4, pct5, pct6)) winner = pct4.Tag.ToString();
            else if (isSameTag(pct7, pct8, pct9)) winner = pct7.Tag.ToString();

            if (winner != null)
            {
                lblResult.Text = $"{winner.ToUpper()} Wins!";
                DisableAllBoxes();
            }
            else if (IsAllPctBoxesChecked())
            {
                lblResult.Text = "It's a draw!";
            }
        }

        void ResetGame()
        {
            lblResult.Text = "Who Will Win";
            currentPlayer = "x";

            foreach(PictureBox pct in pctBoxes)
            {
                pct.Tag = null;
                pct.Image = imgMark;
                pct.Enabled = true;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pct = (PictureBox) sender;
            pct.Image = fillPictureBox(pct);
            pct.Enabled = false;
            isWin();
        }
       
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
