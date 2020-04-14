﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asx_Assign5
{
    public partial class Form1 : Form
    {
        public List<Pieces> _whites;
        public List<Pieces> _blacks;
        public string DISPLAY_TEXT = "Welcome to Chess game. We will be having so much FUN!!!\n\nPlayer 1 : White \n\nPlayer 2 : Black\n\nMay the best Player win!\nGoodluck!!!";
        public Color DISPLAY_COLOR = Color.Green;

        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
        int initSwitch = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (initSwitch == 0)
            {
                InitializeBoard(e.Graphics);
                initSwitch = 1;
            }
            else
            {
                RedraweBoard(e.Graphics);
            }

        }



        #region Initialize Chess Board

        private void RedraweBoard(Graphics g)
        {
            //MessageBox.Show("inredraw");

            DrawBoard(g);
            foreach (var w in _whites)
            {
                g.DrawImage(w.Icon, w.X, w.Y, 50, 50);
            }
            foreach (var w in _blacks)
            {
                g.DrawImage(w.Icon, w.X, w.Y, 50, 50);
            }
        }


        private void DrawBoard(Graphics g)
        {

            int _bX = 10, _bY = 10;
            int _bWidth = 640, _bHeight = 640; //must be multiple of 8
            Brush _borderColor = Brushes.Black;
            Brush[] _bColor = { Brushes.DarkGray, Brushes.Beige };
            //drawing squares
            int spaceX = _bWidth / 8;
            int spaceY = _bHeight / 8;
            for (int c = 0; c < 8; c++)
            {
                for (int r = 0; r < 8; r++)
                {
                    g.FillRectangle(_bColor[(c + r) % 2], _bX + c * spaceX, _bY + r * spaceY, spaceX, spaceY);
                }
            }
            for (int i = 0; i < 8; i++)
            {
                g.DrawLine(new Pen(_borderColor), _bX, _bY + i * spaceY, _bX + _bWidth, _bY + i * spaceY);
                g.DrawLine(new Pen(_borderColor), _bX + i * spaceX, _bY, _bX + i * spaceX, _bY + _bHeight);
            }
            //draw border
            g.DrawRectangle(new Pen(_borderColor, 1), new Rectangle(_bX, _bY, _bWidth, _bHeight));


        }


        private void InitializeBoard(Graphics g)
        {
            int _bX = 10, _bY = 10;
            int _bWidth = 640, _bHeight = 640; //must be multiple of 8
            Brush _borderColor = Brushes.Black;
            Brush[] _bColor = { Brushes.DarkGray, Brushes.Beige };
            //drawing squares
            int spaceX = _bWidth / 8;
            int spaceY = _bHeight / 8;
            for (int c = 0; c < 8; c++)
            {
                for (int r = 0; r < 8; r++)
                {
                    g.FillRectangle(_bColor[(c + r) % 2], _bX + c * spaceX, _bY + r * spaceY, spaceX, spaceY);
                }
            }
            for (int i = 0; i < 8; i++)
            {
                g.DrawLine(new Pen(_borderColor), _bX, _bY + i * spaceY, _bX + _bWidth, _bY + i * spaceY);
                g.DrawLine(new Pen(_borderColor), _bX + i * spaceX, _bY, _bX + i * spaceX, _bY + _bHeight);
            }
            //draw border
            g.DrawRectangle(new Pen(_borderColor, 1), new Rectangle(_bX, _bY, _bWidth, _bHeight));

            InitializePieces(g);

        }

        private void InitializePieces(Graphics g)
        {
            LoadWhitePieces();
            foreach (var w in _whites)
            {
                g.DrawImage(w.Icon, w.X, w.Y, 50, 50);
            }

            LoadBlackPieces();
            foreach (var b in _blacks)
            {
                g.DrawImage(b.Icon, b.X, b.Y, 50, 50);
            }

        }
        #endregion


        #region Load Pieces
        private void LoadWhitePieces()
        {
            int xSpace = -10;
            _whites = new List<Pieces>();
            
            int iXPawn = 0;
            for (int i = 0; i < 8; i++)
            {
                var p = new Pieces
                {
                    
                    Name = "Pawn" + (i + 1),
                    Icon = Image.FromFile(@"../../../Asx_Assign5/Images/WhitePawn.png"),
                    X = 40 + xSpace + iXPawn,
                    Y = 120 + xSpace
                };
                _whites.Add(p);
                iXPawn += 80;
            }
            
            _whites.Add(new Pieces
            {
                Name = "King",
                Icon = Image.FromFile(@"../../../Asx_Assign5/Images/WhiteKing.png"),
                X = 360 + xSpace,
                Y = 40 + xSpace
            });
            _whites.Add(new Pieces
            {
                Name = "Queen",
                Icon = Image.FromFile(@"../../../Asx_Assign5/Images/WhiteQueen.png"),
                X = 280 + xSpace,
                Y = 40 + xSpace
            });
            int iXBishop = 0;
            for (int i = 0; i < 2; i++)
            {
                var p = new Pieces
                {
                    Name = "Bishop" + (i + 1),
                    Icon = Image.FromFile(@"../../../Asx_Assign5/Images/WhiteBishop.png"),
                    X = 200 + xSpace + iXBishop,
                    Y = 40 + xSpace
                };
                _whites.Add(p);
                iXBishop += 240;
            }

            int iXKnight = 0;
            for (int i = 0; i < 2; i++)
            {
                var p = new Pieces
                {
                    Name = "Knight" + (i + 1),
                    Icon = Image.FromFile(@"../../../Asx_Assign5/Images/WhiteKnight.png"),
                    X = 120 + xSpace + iXKnight,
                    Y = 40 + xSpace
                };
                _whites.Add(p);
                iXKnight += 400;
            }

            int iXRook = 0;
            for (int i = 0; i < 2; i++)
            {
                var p = new Pieces
                {
                    Name = "Rook" + (i + 1),
                    Icon = Image.FromFile(@"../../../Asx_Assign5/Images/WhiteRook.png"),
                    X = 40 + xSpace + iXRook,
                    Y = 40 + xSpace
                };
                _whites.Add(p);
                iXRook += 560;
            }

        }





        private void LoadBlackPieces()
        {
            int xSpace = -10;
            _blacks = new List<Pieces>();


            
            int iXPawn = 0;
            for (int i = 0; i < 8; i++)
            {
                var p = new Pieces
                {
                    Name = "Pawn" + (i + 1),
                    Icon = Image.FromFile(@"../../../Asx_Assign5/Images/BlackPawn.png"),
                    X = 40 + xSpace + iXPawn,
                    Y = 520 + xSpace
                };
                _blacks.Add(p);
                iXPawn += 80;
            }
            _blacks.Add(new Pieces
            {
                Name = "King",
                Icon = Image.FromFile(@"../../../Asx_Assign5/Images/BlackKing.png"),
                X = 360 + xSpace,
                Y = 600 + xSpace
            });
            _blacks.Add(new Pieces
            {
                Name = "Queen",
                Icon = Image.FromFile(@"../../../Asx_Assign5/Images/BlackQueen.png"),
                X = 280 + xSpace,
                Y = 600 + xSpace
            });
            int iXBishop = 0;
            for (int i = 0; i < 2; i++)
            {
                var p = new Pieces
                {
                    Name = "Bishop" + (i + 1),
                    Icon = Image.FromFile(@"../../../Asx_Assign5/Images/BlackBishop.png"),
                    X = 200 + xSpace + iXBishop,
                    Y = 600 + xSpace
                };
                _blacks.Add(p);
                iXBishop += 240;
            }

            int iXKnight = 0;
            for (int i = 0; i < 2; i++)
            {
                var p = new Pieces
                {
                    Name = "Knight" + (i + 1),
                    Icon = Image.FromFile(@"../../../Asx_Assign5/Images/BlackKnight.png"),
                    X = 120 + xSpace + iXKnight,
                    Y = 600 + xSpace
                };
                _blacks.Add(p);
                iXKnight += 400;
            }

            int iXRook = 0;
            for (int i = 0; i < 2; i++)
            {
                var p = new Pieces
                {
                    Name = "Rook" + (i + 1),
                    Icon = Image.FromFile(@"../../../Asx_Assign5/Images/BlackRook.png"),
                    X = 40 + xSpace + iXRook,
                    Y = 600 + xSpace
                };
                _blacks.Add(p);
                iXRook += 560;
            }

        }
        #endregion





        int moveSwitch = 0;
        bool whiteTurnSwitch = true;
        Pieces currentPiece;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //convert the X Y 
            int boardX = (e.X - 10) / 80;
            int boardY = (e.Y - 10) / 80;
            Pieces temp;

            //Graphics
            Graphics g;
            g = this.CreateGraphics();


            //select the current piece
            if (whiteTurnSwitch)
            {
                temp = _whites.Find(x => ((x.X == 30 + boardX * 80) && (x.Y == 30 + boardY * 80)));
            }
            else
            {
                temp = _blacks.Find(x => ((x.X == 30 + boardX * 80) && (x.Y == 30 + boardY * 80)));
            }
            RedraweBoard(g);
            //if sth is selected and nothing is selected in the last step
            if (temp != null )
            {
                //MessageBox.Show("step 1");
                currentPiece = temp;
                g.DrawRectangle(new Pen(Brushes.Red, 5), new Rectangle(10 + boardX * 80+5, 10 + boardY * 80+5, 70, 70));
                moveSwitch = 1;

                //visualize the possible grid
                if (currentPiece.Name.Contains("Knight"))
                {

                    KnightPossibleGrid(currentPiece);

                }
               
                if (currentPiece.Name.Contains("Bishop"))
                {
 
                    BishopPossibleGrid(currentPiece);
                }
                
               if (currentPiece.Name.Contains("Rook"))
               {

                   RookPossibleGrid(currentPiece);
               }
                
                if (currentPiece.Name.Contains("Queen"))
                {

                    QueenPossibleGrid(currentPiece);
                }
                
                if (currentPiece.Name.Contains("Pawn"))
                {
                    PawnPossibleGrid(currentPiece);
                }
                
                if (currentPiece.Name.Contains("King"))
                {
                    KingPossibleGrid(currentPiece);
                }



                return;
            }

            //sth is selected and will move in this step
            if (moveSwitch == 1) 
            {
                //MessageBox.Show("step 2");
                string currentPieceName = currentPiece.Name;
                if (currentPieceName.Contains("Knight"))
                {
                    //if the knight is moved, return 0, otherwise,return 1
                    moveSwitch = KnightProcessing(currentPiece, e.X, e.Y);

                }
                if (currentPieceName.Contains("Bishop"))
                {

                    moveSwitch = BishopProcessing(currentPiece, e.X, e.Y);
                }
                if (currentPieceName.Contains("Rook"))
                {

                    moveSwitch = RookProcessing(currentPiece, e.X, e.Y);
                }
                if (currentPieceName.Contains("Queen"))
                {

                    moveSwitch = QueenProcessing(currentPiece, e.X, e.Y);
                }
                if (currentPieceName.Contains("Pawn"))
                {

                    displayText("Pawn", Color.AliceBlue);
                    moveSwitch = PawnProcessing(currentPiece, e.X, e.Y);
                }

                if (currentPieceName.Contains("King"))
                {

                    moveSwitch = KingProcessing(currentPiece, e.X, e.Y);
                }

                if (moveSwitch==0)
                {
                    whiteTurnSwitch = !whiteTurnSwitch;
                    RedraweBoard(g);
                }
        

            }

        }

        private bool checkEmptyGrid(int X, int Y)
        {

            int boardX = (X - 10) / 80;
            int boardY = (Y - 10) / 80;
            //MessageBox.Show("check whether it is empty" + boardX.ToString() + "  " + boardY.ToString());
            Pieces temp1 = _whites.Find(x => ((x.X == 30 + boardX * 80) && (x.Y == 30 + boardY * 80)));
            Pieces temp2 = _blacks.Find(x => ((x.X == 30 + boardX * 80) && (x.Y == 30 + boardY * 80)));

            //no piece in that grid
            if ((temp1 == null) && (temp2 == null))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool checkEnemyGrid(Pieces currentKnight, int X, int Y)
        {
            
            int currentPieceBoardX = (currentKnight.X - 10) / 80;
            int currentPieceBoardY = (currentKnight.Y - 10) / 80;
            int targetgridBoardX = (X - 10) / 80;
            int targetgridBoardY = (Y - 10) / 80;
            Pieces temp;


            if (whiteTurnSwitch ==true)
            {
                temp = _blacks.Find(x => ((x.X == 30 + targetgridBoardX * 80) && (x.Y == 30 + targetgridBoardY * 80)));
            }
            else
            {
                temp = _whites.Find(x => ((x.X == 30 + targetgridBoardX * 80) && (x.Y == 30 + targetgridBoardY * 80)));
            }
            
            //if enemy is not empty
            if (temp != null)
            {
                return true;
            }
            //if enemy is empty
            else
            {
                return false;
            }
        }

        private void removeEnemyPiece(Pieces currentKnight, int X, int Y)
        {
            //MessageBox.Show("removing sth");
            int currentPieceBoardX = (currentKnight.X - 10) / 80;
            int currentPieceBoardY = (currentKnight.Y - 10) / 80;
            int targetgridBoardX = (X - 10) / 80;
            int targetgridBoardY = (Y - 10) / 80;

            Pieces temp;


            if (whiteTurnSwitch == true)
            {
                temp = _blacks.Find(x => ((x.X == 30 + targetgridBoardX * 80) && (x.Y == 30 + targetgridBoardY * 80)));
            }
            else
            {
                temp = _whites.Find(x => ((x.X == 30 + targetgridBoardX * 80) && (x.Y == 30 + targetgridBoardY * 80)));
            }

 
            if (whiteTurnSwitch==true)
            {
                _blacks.RemoveAll(x => ((x.X == 30 + targetgridBoardX * 80) && (x.Y == 30 + targetgridBoardY* 80)));
            }
            else
            {
                _whites.RemoveAll(x => ((x.X == 30 + targetgridBoardX* 80) && (x.Y == 30 + targetgridBoardY* 80)));
            }

           }

        #region knight piece
        private bool CheckKnightMove(Pieces currentKnight, int X, int Y)
        {

            int currentPieceBoardX = (currentKnight.X - 10) / 80;
            int currentPieceBoardY = (currentKnight.Y - 10) / 80;
            int targetgridBoardX = (X - 10) / 80;
            int targetgridBoardY = (Y - 10) / 80;


            if ((currentPieceBoardX == targetgridBoardX) && (currentPieceBoardY == targetgridBoardY))
            {
                //MessageBox.Show("A piece cannot move to his own gird");
                return false;
            }
            if ((targetgridBoardX < 0) || (targetgridBoardX > 7) || (targetgridBoardY < 0) || (targetgridBoardY > 7))
            {
                //MessageBox.Show("A piece cannot move to outside");
                return false;

            }


            if ((Math.Abs(currentPieceBoardX - targetgridBoardX) == 1) && (Math.Abs(currentPieceBoardY - targetgridBoardY) == 2))
            {

                return true;
            }
            if ((Math.Abs(currentPieceBoardX - targetgridBoardX) == 2) && (Math.Abs(currentPieceBoardY - targetgridBoardY) == 1))
            {
                return true;
            }
            return false;
        }
        private int KnightProcessing(Pieces currentKnight, int X,int Y)
        {

            //check whether the knight will move to a reasonbale grid
            if (CheckKnightMove(currentKnight, X, Y))
            {
                // if the target grid is empty, move the piece on it. 
                if (checkEmptyGrid(X, Y))
                {
                    currentPiece.X = 30 + ((X - 10) / 80) * 80;
                    currentPiece.Y = 30 + ((Y - 10) / 80) * 80;
                }
                //if the target grid is occupied by enemy, replaceing the Enemy piece 
                if (checkEnemyGrid(currentKnight, X, Y))
                {
                    //MessageBox.Show("enemy is found");
                    removeEnemyPiece(currentKnight, X, Y);
                    currentPiece.X = 30 + ((X - 10) / 80) * 80;
                    currentPiece.Y = 30 + ((Y - 10) / 80) * 80;

                }


                if (whiteTurnSwitch == true)
                {
                    foreach (var w in _whites)
                    {
                        if (w.Name == currentPiece.Name)
                        {
                            w.X = currentPiece.X;
                            w.Y = currentPiece.Y;
                        }
                    }
                }
                else
                {
                    foreach (var w in _blacks)
                    {
                        if (w.Name == currentPiece.Name)
                        {
                            w.X = currentPiece.X;
                            w.Y = currentPiece.Y;
                        }
                    }
                }
                return 0;
            }
            //the target grid is not reasonable
            else
            {
                MessageBox.Show("This piece cannot reach that square.");
                return 1;
            }
            
        }
        #endregion
        #region Bishop piece
        private bool CheckBishopMove(Pieces currentPiece, int X, int Y)
        {
            int currentPieceBoardX = (currentPiece.X - 10) / 80;
            int currentPieceBoardY = (currentPiece.Y - 10) / 80;
            int targetgridBoardX = (X - 10) / 80;
            int targetgridBoardY = (Y - 10) / 80;
            
            if ((currentPieceBoardX == targetgridBoardX) && (currentPieceBoardY == targetgridBoardY))
            {
                //MessageBox.Show("a piece cannot move to his gird");
                return false;
            }
            if ((targetgridBoardX < 0) || (targetgridBoardX >7) || (targetgridBoardY <0 )|| (targetgridBoardY>7))
            {
                MessageBox.Show("a piece cannot move to outside");
                return false;

            }

            if (   Math.Abs(currentPieceBoardX - targetgridBoardX)  != Math.Abs(currentPieceBoardY - targetgridBoardY)   )
            {
                //MessageBox.Show("Bishop should go dignoal direction");
                return false;
            }

            //MessageBox.Show()
            int hstep = (targetgridBoardX - currentPieceBoardX)/Math.Abs(targetgridBoardX - currentPieceBoardX);
            int vstep = (targetgridBoardY - currentPieceBoardY)/ Math.Abs(targetgridBoardY - currentPieceBoardY);

            //check whether some pieces on the path
            for (int i = 0; i < Math.Abs(targetgridBoardX - currentPieceBoardX)-1; i++ )
            {
                Pieces temp1 = _whites.Find(x => ((x.X == 30 + (currentPieceBoardX + (i + 1) * hstep) * 80) && (x.Y == 30 + (currentPieceBoardY + (i + 1 ) * vstep) * 80)));
                Pieces temp2 = _blacks.Find(x => ((x.X == 30 + (currentPieceBoardX + (i + 1) * hstep) * 80) && (x.Y == 30 + (currentPieceBoardY + (i + 1) * vstep) * 80)));
                if ((temp1 != null) || (temp1 != null))
                {
                    //MessageBox.Show("This move is illegal. Something is on his path.");
                    return false;
                }

            }
            return true;

        }
        private int BishopProcessing(Pieces currentPiece, int X, int Y)
        {

            //check whether the Bishop will move to a reasonbale grid
            if (CheckBishopMove(currentPiece, X, Y))
            {
                // if the target grid is empty, move the piece on it. 
                if (checkEmptyGrid(X, Y))
                {
                    currentPiece.X = 30 + ((X - 10) / 80) * 80;
                    currentPiece.Y = 30 + ((Y - 10) / 80) * 80;
                }
                //if the target grid is occupied by enemy, replaceing the Enemy piece 
                if (checkEnemyGrid(currentPiece, X, Y))
                {
                    //MessageBox.Show("enemy is found");
                    removeEnemyPiece(currentPiece, X, Y);
                    currentPiece.X = 30 + ((X - 10) / 80) * 80;
                    currentPiece.Y = 30 + ((Y - 10) / 80) * 80;
                }


                if (whiteTurnSwitch == true)
                {
                    foreach (var w in _whites)
                    {
                        if (w.Name == currentPiece.Name)
                        {
                            w.X = currentPiece.X;
                            w.Y = currentPiece.Y;
                        }
                    }
                }
                else
                {
                    foreach (var w in _blacks)
                    {
                        if (w.Name == currentPiece.Name)
                        {
                            w.X = currentPiece.X;
                            w.Y = currentPiece.Y;
                        }
                    }
                }
                return 0;
            }
            //the target grid is not reasonable
            else
            {
                MessageBox.Show("This piece cannot reach that square");
                return 1;
            }            
        }


        #endregion

        #region Rook piece

        private bool CheckRookMove(Pieces currentPiece, int X, int Y)
        {
            int currentPieceBoardX = (currentPiece.X - 10) / 80;
            int currentPieceBoardY = (currentPiece.Y - 10) / 80;
            int targetgridBoardX = (X - 10) / 80;
            int targetgridBoardY = (Y - 10) / 80;
            int hstep = 0;
            int vstep = 0;

            if ((currentPieceBoardX == targetgridBoardX) && (currentPieceBoardY == targetgridBoardY))
            {
                //MessageBox.Show("A piece cannot move to his own gird");
                return false;
            }
            if ((targetgridBoardX < 0) || (targetgridBoardX > 7) || (targetgridBoardY < 0) || (targetgridBoardY > 7))
            {
                MessageBox.Show("A piece cannot move to outside");
                return false;

            }
            if (  ((currentPieceBoardX - targetgridBoardX) != 0)  && (currentPieceBoardY - targetgridBoardY)!=0  )
            {
                //MessageBox.Show("Rook can only move in a stright line.");
                return false;
            }

            
            if ( (currentPieceBoardX - targetgridBoardX) == 0  )
            {
                vstep = (targetgridBoardY - currentPieceBoardY) / Math.Abs(targetgridBoardY - currentPieceBoardY);
            }
            if ((currentPieceBoardY - targetgridBoardY) == 0)
            {
                hstep = (targetgridBoardX - currentPieceBoardX) / Math.Abs(targetgridBoardX - currentPieceBoardX);
            }

                
            

            //check whether some pieces on the path
            for (int i = 0; i < Math.Abs(targetgridBoardX - currentPieceBoardX) - 1; i++)
            {
                Pieces temp1 = _whites.Find(x => ((x.X == 30 + (currentPieceBoardX + (i + 1) * hstep) * 80) && (x.Y == 30 + (currentPieceBoardY + (i ) * vstep) * 80)));
                Pieces temp2 = _blacks.Find(x => ((x.X == 30 + (currentPieceBoardX + (i + 1) * hstep) * 80) && (x.Y == 30 + (currentPieceBoardY + (i ) * vstep) * 80)));
                if ((temp1 != null) || (temp2 != null))
                {
                    //MessageBox.Show("This move is illegal.Somethig is on his path.");
                    return false;
                }

            }
            for (int i = 0; i < Math.Abs(targetgridBoardY - currentPieceBoardY) - 1; i++)
            {
                Pieces temp1 = _whites.Find(x => ((x.X == 30 + (currentPieceBoardX + (i ) * hstep) * 80) && (x.Y == 30 + (currentPieceBoardY + (i + 1) * vstep) * 80)));
                Pieces temp2 = _blacks.Find(x => ((x.X == 30 + (currentPieceBoardX + (i ) * hstep) * 80) && (x.Y == 30 + (currentPieceBoardY + (i + 1) * vstep) * 80)));
                if ((temp1 != null) || (temp2 != null))
                {
                    //MessageBox.Show("This move is illegal.Somethig is on his path.");
                    return false;
                }

            }
            return true;

        }


        private int RookProcessing(Pieces currentPiece, int X, int Y)
        {
            //check whether the Rook will move to a reasonbale grid
            if (CheckRookMove(currentPiece, X, Y))
            {
                // if the target grid is empty, move the piece on it. 
                if (checkEmptyGrid(X, Y))
                {
                    currentPiece.X = 30 + ((X - 10) / 80) * 80;
                    currentPiece.Y = 30 + ((Y - 10) / 80) * 80;
                }
                //if the target grid is occupied by enemy, replaceing the Enemy piece 
                if (checkEnemyGrid(currentPiece, X, Y))
                {
                    //MessageBox.Show("enemy is found");
                    removeEnemyPiece(currentPiece, X, Y);
                    currentPiece.X = 30 + ((X - 10) / 80) * 80;
                    currentPiece.Y = 30 + ((Y - 10) / 80) * 80;
                }


                if (whiteTurnSwitch == true)
                {
                    foreach (var w in _whites)
                    {
                        if (w.Name == currentPiece.Name)
                        {
                            w.X = currentPiece.X;
                            w.Y = currentPiece.Y;
                        }
                    }
                }
                else
                {
                    foreach (var w in _blacks)
                    {
                        if (w.Name == currentPiece.Name)
                        {
                            w.X = currentPiece.X;
                            w.Y = currentPiece.Y;
                        }
                    }
                }
                return 0;
            }
            //the target grid is not reasonable
            else
            {
                MessageBox.Show("This piece cannot reach that square");
                return 1;
            }
        }


        #endregion

        #region queen piece

        private bool CheckQueenMove(Pieces currentPiece, int X, int Y)
        {
            int currentPieceBoardX = (currentPiece.X - 10) / 80;
            int currentPieceBoardY = (currentPiece.Y - 10) / 80;
            int targetgridBoardX = (X - 10) / 80;
            int targetgridBoardY = (Y - 10) / 80;
            int hstep = 0;
            int vstep = 0;

            if ((currentPieceBoardX == targetgridBoardX) && (currentPieceBoardY == targetgridBoardY))
            {
                //MessageBox.Show("a piece cannot move to his own gird");
                return false;
            }
            if ((targetgridBoardX < 0) || (targetgridBoardX > 7) || (targetgridBoardY < 0) || (targetgridBoardY > 7))
            {
                //MessageBox.Show("a piece cannot move to outside");
                return false;

            }
            if (  ((currentPieceBoardX - targetgridBoardX) == 0) || ((currentPieceBoardY - targetgridBoardY) == 0) || (Math.Abs(currentPieceBoardX - targetgridBoardX) == Math.Abs(currentPieceBoardY - targetgridBoardY)))
            {
                if ((currentPieceBoardX - targetgridBoardX) == 0)
                {
                    vstep = (targetgridBoardY - currentPieceBoardY) / Math.Abs(targetgridBoardY - currentPieceBoardY);
                }
                else if ((currentPieceBoardY - targetgridBoardY) == 0)
                {
                    hstep = (targetgridBoardX - currentPieceBoardX) / Math.Abs(targetgridBoardX - currentPieceBoardX);
                }
                else
                {
                    hstep = (targetgridBoardX - currentPieceBoardX) / Math.Abs(targetgridBoardX - currentPieceBoardX);
                    vstep = (targetgridBoardY - currentPieceBoardY) / Math.Abs(targetgridBoardY - currentPieceBoardY);
                }

                //check whether some pieces on the path
                for (int i = 0; i < Math.Abs(targetgridBoardX - currentPieceBoardX) - 1; i++)
                {
                    Pieces temp1 = _whites.Find(x => ((x.X == 30 + (currentPieceBoardX + (i + 1) * hstep) * 80) && (x.Y == 30 + (currentPieceBoardY + (i + 1) * vstep) * 80)));
                    Pieces temp2 = _blacks.Find(x => ((x.X == 30 + (currentPieceBoardX + (i + 1) * hstep) * 80) && (x.Y == 30 + (currentPieceBoardY + (i + 1) * vstep) * 80)));
                    if ((temp1 != null) || (temp2 != null))
                    {
                        //MessageBox.Show("sth is on the path");
                        return false;
                    }

                }

                for (int i = 0; i < Math.Abs(targetgridBoardY - currentPieceBoardY) - 1; i++)
                {
                    Pieces temp1 = _whites.Find(x => ((x.X == 30 + (currentPieceBoardX + (i + 1) * hstep) * 80) && (x.Y == 30 + (currentPieceBoardY + (i + 1) * vstep) * 80)));
                    Pieces temp2 = _blacks.Find(x => ((x.X == 30 + (currentPieceBoardX + (i + 1) * hstep) * 80) && (x.Y == 30 + (currentPieceBoardY + (i + 1) * vstep) * 80)));
                    if ((temp1 != null) || (temp2 != null))
                    {
                        //MessageBox.Show("sth is on the path");
                        return false;
                    }

                }


                return true;

            }
            else
            {
                
                return false;
            }

        }


        private int QueenProcessing(Pieces currentPiece, int X, int Y)
        {
            //check whether the Rook will move to a reasonbale grid
            if (CheckQueenMove(currentPiece, X, Y))
            {
                // if the target grid is empty, move the piece on it. 
                if (checkEmptyGrid(X, Y))
                {
                    currentPiece.X = 30 + ((X - 10) / 80) * 80;
                    currentPiece.Y = 30 + ((Y - 10) / 80) * 80;
                }
                //if the target grid is occupied by enemy, replaceing the Enemy piece 
                if (checkEnemyGrid(currentPiece, X, Y))
                {
                    //MessageBox.Show("enemy is found");
                    removeEnemyPiece(currentPiece, X, Y);
                    currentPiece.X = 30 + ((X - 10) / 80) * 80;
                    currentPiece.Y = 30 + ((Y - 10) / 80) * 80;
                }


                if (whiteTurnSwitch == true)
                {
                    foreach (var w in _whites)
                    {
                        if (w.Name == currentPiece.Name)
                        {
                            w.X = currentPiece.X;
                            w.Y = currentPiece.Y;
                        }
                    }
                }
                else
                {
                    foreach (var w in _blacks)
                    {
                        if (w.Name == currentPiece.Name)
                        {
                            w.X = currentPiece.X;
                            w.Y = currentPiece.Y;
                        }
                    }
                }
                return 0;
            }
            //the target grid is not reasonable
            else
            {
                MessageBox.Show("This piece cannot reach that square");
                return 1;
            }
        }
        #endregion


        #region Pawn piece



        private bool CheckPawnMove(Pieces currentPiece, int X, int Y)
        {
            int currentPieceBoardX = (currentPiece.X - 10) / 80;
            int currentPieceBoardY = (currentPiece.Y - 10) / 80;
            int targetgridBoardX = (X - 10) / 80;
            int targetgridBoardY = (Y - 10) / 80;

            int hstep = targetgridBoardX - currentPieceBoardX;
            int vstep = targetgridBoardY - currentPieceBoardY;


            if ((hstep == 0) && (vstep == 0))
            {
                //MessageBox.Show("a piece cannot move to his own gird");
                return false;
            }
            if ((targetgridBoardX < 0) || (targetgridBoardX > 7) || (targetgridBoardY < 0) || (targetgridBoardY > 7))
            {
                //MessageBox.Show("a piece cannot move to outside");
                return false;

            }


            if (whiteTurnSwitch == true)
            {

                if (currentPieceBoardY == 1)
                {
                    if( (vstep ==1) &&  (hstep == 0) && (checkEmptyGrid(X, Y )))   
                    {
                        return true;
                    }
                    if( (vstep == 2) && (hstep == 0) && (checkEmptyGrid(X, Y )) && (checkEmptyGrid(X, Y -80)))
                    {
                        return true;
                    }
                    if ((vstep == 1) && (Math.Abs(hstep) == 1) && (checkEnemyGrid(currentPiece, X, Y)))
                    {
                        //MessageBox.Show("attack!!!!!!!!!!!!!!");
                        return true;
                    }
                }
                else
                {
                    if ((vstep == 1) && (hstep == 0) && (checkEmptyGrid(X, Y)))
                    {
                        return true;
                    }
                    if ((vstep == 1) && (Math.Abs(hstep) == 1) && (checkEnemyGrid(currentPiece, X, Y)))
                    {
                        //MessageBox.Show("attack!!!!!!!!!!!!!!");
                        return true;
                    }
                    
                    return false;
                }

            }
            else
            {
                if (currentPieceBoardY == 6)
                {
                    if ((vstep == -1) && (hstep == 0) && (checkEmptyGrid(X, Y)))
                    {
                        return true;
                    }
                    if ((vstep == -2) && (hstep == 0) && (checkEmptyGrid(X, Y )) && (checkEmptyGrid(X, Y +80)))
                    {
                        return true;
                    }
                    if ((vstep == -1) && (Math.Abs(hstep) == 1) && (checkEnemyGrid(currentPiece, X, Y)))
                    {
                        //MessageBox.Show("attack!!!!!!!!!!!!!!");
                        return true;
                    }

                }
                else
                {
                    if ((vstep == -1) && (hstep == 0) && (checkEmptyGrid(X, Y)))
                    {
                        return true;
                    }
                    else if ((vstep == -1) && (Math.Abs(hstep) == 1) && (checkEnemyGrid(currentPiece, X, Y)))
                    {
                        //MessageBox.Show("attack");
                        return true;
                    }

                    return false;
                }
            }
            return false;



        }


        private int PawnProcessing(Pieces currentPiece, int X, int Y)
        {
            //check whether the Rook will move to a reasonbale grid
            if (CheckPawnMove(currentPiece, X, Y))
            {
                // if the target grid is empty, move the piece on it. 
                if (checkEmptyGrid(X, Y))
                {

                    currentPiece.X = 30 + ((X - 10) / 80) * 80;
                    currentPiece.Y = 30 + ((Y - 10) / 80) * 80;
                }
                //if the target grid is occupied by enemy, replaceing the Enemy piece 
                if (checkEnemyGrid(currentPiece, X, Y))
                {

                    removeEnemyPiece(currentPiece, X, Y);
                    currentPiece.X = 30 + ((X - 10) / 80) * 80;
                    currentPiece.Y = 30 + ((Y - 10) / 80) * 80;
                }


                if (whiteTurnSwitch == true)
                {
                    foreach (var w in _whites)
                    {
                        if (w.Name == currentPiece.Name)
                        {
                            w.X = currentPiece.X;
                            w.Y = currentPiece.Y;
                        }
                    }
                }
                else
                {
                    foreach (var w in _blacks)
                    {
                        if (w.Name == currentPiece.Name)
                        {
                            w.X = currentPiece.X;
                            w.Y = currentPiece.Y;
                        }
                    }
                }
                return 0;
            }
            //the target grid is not reasonable
            else
            {
                MessageBox.Show("This piece cannot reach that square");
                return 1;
            }
        }
        #endregion


        #region King piece
        private bool CheckKingMove(Pieces currentPiece, int X, int Y)
        {
            int currentPieceBoardX = (currentPiece.X - 10) / 80;
            int currentPieceBoardY = (currentPiece.Y - 10) / 80;
            int targetgridBoardX = (X - 10) / 80;
            int targetgridBoardY = (Y - 10) / 80;

            int hstep = targetgridBoardX - currentPieceBoardX;
            int vstep = targetgridBoardY - currentPieceBoardY;
            Pieces temp;


            int tempX = 0;
            int tempY = 0;

            if ((currentPieceBoardX == targetgridBoardX) && (currentPieceBoardY == targetgridBoardY))
            {
                //MessageBox.Show("a piece cannot move to his own gird");
                return false;
            }
            if ((targetgridBoardX < 0) || (targetgridBoardX > 7) || (targetgridBoardY < 0) || (targetgridBoardY > 7))
            {
                //MessageBox.Show("a piece cannot move to outside");
                return false;

            }

            if ((Math.Abs(hstep) <= 1) && (Math.Abs(vstep) <= 1))
            {


                #region white king
                if (whiteTurnSwitch == true)
                {
                    //cross
                    #region straight lines
                    //to right
                    tempX = targetgridBoardX + 1;
                    tempY = targetgridBoardY;
                    while( checkEmptyGrid(30+tempX*80,30 + tempY*80))
                    {
                        //MessageBox.Show("to right" + tempX.ToString() + "   " + tempY.ToString());
                        tempX = tempX + 1;
                        tempY = tempY;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            break;
                        }

                    }
                    temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Rook")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Rook");
                        return false;
                    }

                    //to bottom
                    tempX = targetgridBoardX;
                    tempY = targetgridBoardY + 1;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {                   
                        tempX = tempX;
                        tempY = tempY + 1;                        
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            break;
                        }
                    }
                    temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Rook")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Rook");
                        return false;
                    }

                    //to left
                    tempX = targetgridBoardX - 1;
                    tempY = targetgridBoardY;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {
                        tempX = tempX - 1;
                        tempY = tempY;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            break;
                        }
                    }
                    temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));

                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Rook")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Rook");
                        return false;
                    }


                    //to top
                    tempX = targetgridBoardX ;
                    tempY = targetgridBoardY - 1;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {
                        tempX = tempX;
                        tempY = tempY - 1;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            break;
                        }

                    }
                    temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));

                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Rook")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Rook");
                        return false;
                    }
                    #endregion


                    //dignola
                    #region Diagonal 
                    //to bottom-left
                    tempX = targetgridBoardX + 1;
                    tempY = targetgridBoardY + 1;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {
                        tempX = tempX + 1;
                        tempY = tempY + 1;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            break;
                        }


                    }
                    temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Bishop")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Bishop");
                        return false;
                    }


                    tempX = targetgridBoardX-1;
                    tempY = targetgridBoardY-1;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {
                        tempX = tempX - 1;
                        tempY = tempY - 1;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            break;
                        }
                    }
                    temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Bishop")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Bishop");
                        return false;
                    }


                    tempX = targetgridBoardX-1;
                    tempY = targetgridBoardY+1;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {
                        tempX = tempX - 1;
                        tempY = tempY + 1;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            //MessageBox.Show("time to break");
                            break;
                        }

                    }
                    temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Bishop")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Bishop");
                        return false;
                    }



                    tempX = targetgridBoardX + 1;
                    tempY = targetgridBoardY - 1;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {
                        tempX = tempX + 1;
                        tempY = tempY - 1;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            break;
                        }

                    }
                    temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Bishop")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Bishop");
                        return false;
                    }
                    #endregion
                    //L form
                    for (int i = -2;i<3;i = i+4)
                        for(int j = -1; j < 2; j = j + 2)
                        {
                            tempX = targetgridBoardX + i;
                            tempY = targetgridBoardY + j;
                            temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                            if ((temp != null) && (temp.Name.Contains("Knight") ))
                            {
                                //MessageBox.Show("will be attacked by Knight");
                                return false;
                            }
                        }
                    for (int i = -1; i < 2; i = i + 2)
                        for (int j = -2; j < 3; j = j + 4)
                        {
                            tempX = targetgridBoardX + i;
                            tempY = targetgridBoardY + j;
                            temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                            if ((temp != null) && (temp.Name.Contains("Knight")))
                            {
                                //MessageBox.Show("will be attacked by Knight");
                                return false;
                            }
                        }

                    //detect Pawn
                    tempX = targetgridBoardX + 1;
                    tempY = targetgridBoardY + 1;
                    temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Pawn")))
                    {
                        //MessageBox.Show("will be attacked by Pawn");
                        return false;
                    }

                    tempX = targetgridBoardX - 1;
                    tempY = targetgridBoardY + 1;
                    temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Pawn")))
                    {
                        //MessageBox.Show("will be attacked by Pawn");
                        return false;
                    }
                    //detect King
                    for(int i =-1;i<2;i++)
                        for (int j = -1; j < 2; j++)
                        {
                            tempX = targetgridBoardX + i;
                            tempY = targetgridBoardY + j;
                            temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                            if ((temp != null) && (temp.Name.Contains("King")))
                            {
                                //MessageBox.Show("will be attacked by Pawn");
                                return false;
                            }
                        }

                }
                #endregion

                #region black king
                else
                {
                    //cross
                    #region straight lines
                    //to right
                    tempX = targetgridBoardX + 1;
                    tempY = targetgridBoardY;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {                  
                        tempX = tempX + 1;
                        tempY = tempY;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            break;
                        }

                    }

                    temp = _whites.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));

                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Rook")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Rook");
                        return false;
                    }

                    //to bottom
                    tempX = targetgridBoardX;
                    tempY = targetgridBoardY + 1;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {             
                        tempX = tempX;
                        tempY = tempY + 1;

                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            break;
                        }
                    }
                    temp = _whites.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));

                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Rook")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Rook");
                        return false;
                    }

                    //to left
                    tempX = targetgridBoardX - 1;
                    tempY = targetgridBoardY;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {
                        tempX = tempX - 1;
                        tempY = tempY;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            break;
                        }
                    }
                    temp = _whites.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));

                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Rook")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Rook");
                        return false;
                    }


                    //to top
                    tempX = targetgridBoardX;
                    tempY = targetgridBoardY - 1;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {
                        tempX = tempX;
                        tempY = tempY - 1;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            //MessageBox.Show("time to break");
                            break;
                        }

                    }
                    temp = _whites.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));

                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Rook")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Rook");
                        return false;
                    }
                    #endregion


                    //dignola
                    #region Diagonal 
                    //to bottom-left
                    tempX = targetgridBoardX + 1;
                    tempY = targetgridBoardY + 1;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {
                        tempX = tempX + 1;
                        tempY = tempY + 1;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            //MessageBox.Show("time to break");
                            break;
                        }


                    }
                    temp = _whites.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Bishop")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Bishop");
                        return false;
                    }


                    tempX = targetgridBoardX - 1;
                    tempY = targetgridBoardY - 1;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {
                        tempX = tempX - 1;
                        tempY = tempY - 1;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            //MessageBox.Show("time to break");
                            break;
                        }
                    }
                    temp = _whites.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Bishop")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Bishop");
                        return false;
                    }


                    tempX = targetgridBoardX - 1;
                    tempY = targetgridBoardY + 1;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {
                        tempX = tempX - 1;
                        tempY = tempY + 1;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            //MessageBox.Show("time to break");
                            break;
                        }

                    }
                    temp = _whites.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Bishop")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Bishop");
                        return false;
                    }



                    tempX = targetgridBoardX + 1;
                    tempY = targetgridBoardY - 1;
                    while (checkEmptyGrid(30 + tempX * 80, 30 + tempY * 80))
                    {
                        tempX = tempX + 1;
                        tempY = tempY - 1;
                        if ((tempX < 0) || (tempX > 7) || (tempY < 0) || (tempY > 7))
                        {
                            break;
                        }

                    }
                    temp = _whites.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Queen") || temp.Name.Contains("Bishop")))
                    {
                        //MessageBox.Show("will be attacked by Queen or Bishop");
                        return false;
                    }
                    #endregion
                    //L form
                    for (int i = -2; i < 3; i = i + 4)
                        for (int j = -1; j < 2; j = j + 2)
                        {
                            tempX = targetgridBoardX + i;
                            tempY = targetgridBoardY + j;
                            temp = _whites.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                            if ((temp != null) && (temp.Name.Contains("Knight")))
                            {
                                //MessageBox.Show("will be attacked by Knight");
                                return false;
                            }
                        }
                    for (int i = -1; i < 2; i = i + 2)
                        for (int j = -2; j < 3; j = j + 4)
                        {
                            tempX = targetgridBoardX + i;
                            tempY = targetgridBoardY + j;
                            temp = _whites.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                            if ((temp != null) && (temp.Name.Contains("Knight")))
                            {
                                //MessageBox.Show("will be attacked by Knight");
                                return false;
                            }
                        }

                    //detect Pawn
                    tempX = targetgridBoardX + 1;
                    tempY = targetgridBoardY - 1;
                    temp = _blacks.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Pawn")))
                    {
                        //MessageBox.Show("will be attacked by Pawn");
                        return false;
                    }

                    tempX = targetgridBoardX - 1;
                    tempY = targetgridBoardY - 1;
                    temp = _whites.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                    if ((temp != null) && (temp.Name.Contains("Pawn")))
                    {
                        //MessageBox.Show("will be attacked by Pawn");
                        return false;
                    }
                    //detect King
                    for (int i = -1; i < 2; i++)
                        for (int j = -1; j < 2; j++)
                        {
                            tempX = targetgridBoardX + i;
                            tempY = targetgridBoardY + j;
                            temp = _whites.Find(x => ((x.X == 30 + tempX * 80) && (x.Y == 30 + tempY * 80)));
                            if ((temp != null) && (temp.Name.Contains("King")))
                            {
                                //MessageBox.Show("will be attacked by Pawn");
                                return false;
                            }
                        }

                }
                #endregion
            }
            else
            {
                //MessageBox.Show("only one pace is allowed");
                return false;
            }           
            return true;





        }
        private int KingProcessing(Pieces currentPiece, int X, int Y)
        {

            int currentPieceBoardX = (currentPiece.X - 10) / 80;
            int currentPieceBoardY = (currentPiece.Y - 10) / 80;
            int targetgridBoardX = (X - 10) / 80;
            int targetgridBoardY = (Y - 10) / 80;

            int hstep = targetgridBoardX - currentPieceBoardX;
            int vstep = targetgridBoardY - currentPieceBoardY;


            //check whether the knight will move to a reasonbale grid
            if (CheckKingMove(currentPiece, X, Y))
            {
                // if the target grid is empty, move the piece on it. 
                if (checkEmptyGrid(X, Y))
                {
                    currentPiece.X = 30 + ((X - 10) / 80) * 80;
                    currentPiece.Y = 30 + ((Y - 10) / 80) * 80;
                }
                //if the target grid is occupied by enemy, replaceing the Enemy piece 
                if (checkEnemyGrid(currentPiece, X, Y))
                {
                    //MessageBox.Show("enemy is found");
                    removeEnemyPiece(currentPiece, X, Y);
                    currentPiece.X = 30 + ((X - 10) / 80) * 80;
                    currentPiece.Y = 30 + ((Y - 10) / 80) * 80;
                }


                if (whiteTurnSwitch == true)
                {
                    foreach (var w in _whites)
                    {
                        if (w.Name == currentPiece.Name)
                        {
                            w.X = currentPiece.X;
                            w.Y = currentPiece.Y;
                        }
                    }
                }
                else
                {
                    foreach (var w in _blacks)
                    {
                        if (w.Name == currentPiece.Name)
                        {
                            w.X = currentPiece.X;
                            w.Y = currentPiece.Y;
                        }
                    }
                }
                return 0;
            }
            //the target grid is not reasonable
            else
            {
                if (  checkEmptyGrid(X,Y) && ((Math.Abs(hstep) <= 1) && (Math.Abs(vstep) <= 1)) && (CheckKingMove(currentPiece, X, Y)==false) )
                {
                    MessageBox.Show("This move exposes the King to attack");
                    return 1;
                }
                else
                {
                    MessageBox.Show("This piece cannot reach that squar");
                    return 1;
                }
            }
        }


        #endregion


        #region possible grid
        private void KnightPossibleGrid(Pieces currentPiece)
        {
            Graphics g;
            g = this.CreateGraphics();
            for (int i = 0; i<8;i++)
                for (int j = 0; j < 8; j++)
                {
                    if ( (CheckKnightMove(currentPiece,30+i*80,30+j*80)) && ((checkEmptyGrid(30 + i * 80, 30 + j * 80)) || checkEnemyGrid(currentPiece, 30 + i * 80, 30 + j * 80))   )
                    {
                        g.DrawRectangle(new Pen(Brushes.Green, 5), new Rectangle(10 + i * 80 + 10, 10 + j * 80 + 10, 60, 60));
                    }
                }


        }

        private void BishopPossibleGrid(Pieces currentPiece)
        {
            Graphics g;
            g = this.CreateGraphics();
            
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if ((CheckBishopMove(currentPiece, 30 + i * 80, 30 + j * 80)) && ((checkEmptyGrid(30 + i * 80, 30 + j * 80)) || checkEnemyGrid(currentPiece, 30 + i * 80, 30 + j * 80)))
                    {
                        g.DrawRectangle(new Pen(Brushes.Green, 5), new Rectangle(10 + i * 80 + 10, 10 + j * 80 + 10, 60, 60));
                    }
                }


        }

        private void RookPossibleGrid(Pieces currentPiece)
        {
            Graphics g;
            g = this.CreateGraphics();

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if ((CheckRookMove(currentPiece, 30 + i * 80, 30 + j * 80)) && ((checkEmptyGrid(30 + i * 80, 30 + j * 80)) || checkEnemyGrid(currentPiece, 30 + i * 80, 30 + j * 80)))
                    {
                        g.DrawRectangle(new Pen(Brushes.Green, 5), new Rectangle(10 + i * 80 + 10, 10 + j * 80+10, 60, 60));
                    }
                }
        }


        private void QueenPossibleGrid(Pieces currentPiece)
        {
            Graphics g;
            g = this.CreateGraphics();

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if ((CheckQueenMove(currentPiece, 30 + i * 80, 30 + j * 80)) && ((checkEmptyGrid(30 + i * 80, 30 + j * 80)) || checkEnemyGrid(currentPiece, 30 + i * 80, 30 + j * 80)))
                    {
                        g.DrawRectangle(new Pen(Brushes.Green, 5), new Rectangle(10 + i * 80+10, 10 + j * 80+10, 60, 60));
                    }
                }
        }


        private void PawnPossibleGrid(Pieces currentPiece)
        {
            Graphics g;
            g = this.CreateGraphics();

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if ((CheckPawnMove(currentPiece, 30 + i * 80, 30 + j * 80)) && ((checkEmptyGrid(30 + i * 80, 30 + j * 80)) || checkEnemyGrid(currentPiece, 30 + i * 80, 30 + j * 80)))
                    {
                        g.DrawRectangle(new Pen(Brushes.Green, 5), new Rectangle(10 + i * 80+10, 10 + j * 80+10, 60, 60));
                    }
                }

        }

        private void KingPossibleGrid(Pieces currentPiece)
        {
            Graphics g;
            g = this.CreateGraphics();

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if ((CheckKingMove(currentPiece, 30 + i * 80, 30 + j * 80)) && ((checkEmptyGrid(30 + i * 80, 30 + j * 80)) || checkEnemyGrid(currentPiece, 30 + i * 80, 30 + j * 80)))
                    {
                        g.DrawRectangle(new Pen(Brushes.Green, 5), new Rectangle(10 + i * 80+10, 10 + j * 80+10, 60, 60));
                    }
                }
        }

        #endregion



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 14))
            {

                StringFormat drawFormat = new StringFormat();
                e.Graphics.DrawString(DISPLAY_TEXT, myFont, new SolidBrush(DISPLAY_COLOR), pictureBox1.ClientRectangle);
               // e.Graphics.DrawString("Hello we are having a good time, so you can go F yourself \n\n\nThe point is : 10 \n\n\n we are good\n", myFont, new SolidBrush(DISPLAY_COLOR), pictureBox1.ClientRectangle);

            }
        }

        private void displayText(string txt, Color t)
        {
            DISPLAY_TEXT = txt;
            DISPLAY_COLOR = t;
            pictureBox1.Refresh();
        }

    }
}
