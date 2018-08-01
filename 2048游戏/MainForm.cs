using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _2048游戏
{
    public enum Direction
    {
        Left,
        Up,
        Right,
        Down
    }
    public partial class MainForm : Form
    {
        private int[,] _numberMap;
        private Button[,] _blockMap;
        private const int BlockLength = 120;
        private const int BlockGap = 5;
        private const int RowCount = 4;
        private const int ColumnCount = 4;
        private readonly Random _ran = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void StartClick(object sender, EventArgs e)
        {
            Start.Enabled = false;
            Start.Hide();
            Label2048.Hide();
            Tips.Hide();
            InitAllBlocks();
            AddNewBlock();
        }

        private void HelpsClick(object sender, EventArgs e)
        {
            MessageBox.Show("Press ←: Left\nPress ↑: Up\nPress →: Right\nPress ↓: Down");
        }

        private void MainFormKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    MoveTo(Direction.Down);
                    break;
                case Keys.Up:
                    MoveTo(Direction.Up);
                    break;
                case Keys.Left:
                    MoveTo(Direction.Left);
                    break;
                case Keys.Right:
                    MoveTo(Direction.Right);
                    break;
            }
        }

        private void UpdateBlockColor(int i, int j)
        {
            var bt = _blockMap[i, j];
            switch (_numberMap[i, j])
            {
                case 0x0:
                    bt.BackColor = Color.LightCyan;
                    break;
                case 0x2:
                    bt.BackColor = Color.Cyan;
                    break;
                case 0x4:
                    bt.BackColor = Color.Turquoise;
                    break;
                case 0x8:
                    bt.BackColor = Color.DarkTurquoise;
                    break;
                case 0x10:
                    bt.BackColor = Color.GreenYellow;
                    break;
                case 0x20:
                    bt.BackColor = Color.Chartreuse;
                    break;
                case 0x40:
                    bt.BackColor = Color.Lime;
                    break;
                case 0x80:
                    bt.BackColor = Color.MediumSpringGreen;
                    break;
                case 0x100:
                    bt.BackColor = Color.NavajoWhite;
                    break;
                case 0x200:
                    bt.BackColor = Color.Coral;
                    break;
                case 0x400:
                    bt.BackColor = Color.DarkOrange;
                    break;
                case 0x800:
                    bt.BackColor = Color.DarkSalmon;
                    break;
                default:
                    bt.BackColor = Color.OrangeRed;
                    break;
            }
        }

        private bool AddNewBlock()
        {
            var emtlst = new List<int[]>();
            for (var i = 0; i < ColumnCount; i++)
            for (var j = 0; j < RowCount; j++)
                if (_numberMap[i, j] == 0)
                    emtlst.Add(new[] {i, j});
            if (emtlst.Count == 0) return false;
            var r = _ran.Next(0, emtlst.Count);
            _numberMap[emtlst[r][0], emtlst[r][1]] = _ran.Next(0, 4) == 0 ? 4 : 2;
            UpdateBlock(emtlst[r][0], emtlst[r][1]);
            return true;
        }

        private void GameOver()
        {
            MessageBox.Show("Game over");
            ClearNumberMap();
            UpdateAllBlock();
            AddNewBlock();
        }

        private void ClearNumberMap()
        {
            for (var i = 0; i < RowCount; i++)
            {
                for (var j = 0; j < ColumnCount; j++)
                    _numberMap[i, j] = 0;
            }
        }

        private void UpdateBlock(int i, int j)
        {
            _blockMap[i, j].Text = _numberMap[i, j] == 0 ? "" : _numberMap[i, j].ToString();
            UpdateBlockColor(i, j);
        }

        private void UpdateAllBlock()
        {
            for (var i = 0; i < RowCount; i++)
            for (var j = 0; j < ColumnCount; j++)
                UpdateBlock(i, j);
        }

        private void InitAllBlocks()
        {
            _numberMap = new int[RowCount, ColumnCount];
            _blockMap = new Button[RowCount, ColumnCount];
            for (var y = 0; y < RowCount; y++)
            {
                for (var x = 0; x < ColumnCount; x++)
                {
                    _numberMap[y, x] = 0;
                    _blockMap[y, x] = new Button
                    {
                        Width = BlockLength,
                        Height = BlockLength,
                        Font = new Font("微软雅黑", 20),
                        BackColor = Color.LightCyan,
                        Name = (RowCount * y + x).ToString(),
                        Text = "",
                        FlatStyle = FlatStyle.Flat,
                        Enabled = false,
                        Location = new Point((BlockLength + BlockGap) * x + 10, (BlockLength + BlockGap) * y + 10)
                    };
                    _blockMap[y, x].FlatAppearance.BorderSize = 0;
                    Controls.Add(_blockMap[y, x]);
                }
            }
        }

        private void MoveTo(Direction dir)
        {
            var temp = new List<int>();
            switch (dir)
            {
                case Direction.Left:
                    for (var y = 0; y < RowCount; y++)
                    {
                        for (var x = 0; x < ColumnCount; x++)
                        {
                            if (_numberMap[y, x] == 0) continue;
                            if (temp.Count == 0)
                            {
                                temp.Add(_numberMap[y, x]);
                                continue;
                            }

                            if (_numberMap[y, x] == temp.Last())
                            {
                                temp[temp.Count - 1] += _numberMap[y, x];
                            }
                            else
                            {
                                temp.Add(_numberMap[y, x]);
                            }
                        }

                        for (var x = 0; x < ColumnCount; x++)
                        {
                            _numberMap[y, x] = x < temp.Count ? temp[x] : 0;
                            UpdateBlock(y, x);
                        }

                        temp.Clear();
                    }

                    break;
                case Direction.Up:
                    for (var x = 0; x < ColumnCount; x++)
                    {
                        for (var y = 0; y < RowCount; y++)
                        {
                            if (_numberMap[y, x] == 0) continue;
                            if (temp.Count == 0)
                            {
                                temp.Add(_numberMap[y, x]);
                                continue;
                            }

                            if (_numberMap[y, x] == temp.Last())
                            {
                                temp[temp.Count - 1] += _numberMap[y, x];
                            }
                            else
                            {
                                temp.Add(_numberMap[y, x]);
                            }
                        }

                        for (var y = 0; y < RowCount; y++)
                        {
                            _numberMap[y, x] = y < temp.Count ? temp[y] : 0;
                            UpdateBlock(y, x);
                        }

                        temp.Clear();
                    }

                    break;
                case Direction.Right:
                    for (var y = 0; y < RowCount; y++)
                    {
                        for (var x = ColumnCount - 1; x >= 0; x--)
                        {
                            if (_numberMap[y, x] == 0)
                                continue;
                            if (temp.Count == 0)
                            {
                                temp.Add(_numberMap[y, x]);
                                continue;
                            }

                            if (_numberMap[y, x] == temp.Last())
                                temp[temp.Count - 1] += _numberMap[y, x];
                            else
                                temp.Add(_numberMap[y, x]);
                        }

                        for (int i = ColumnCount - 1, j = 0; i >= 0; i--, j++)
                        {
                            _numberMap[y, i] = j < temp.Count ? temp[j] : 0;
                            UpdateBlock(y, i);
                        }

                        temp.Clear();
                    }

                    break;
                case Direction.Down:
                    for (var x = 0; x < ColumnCount; x++)
                    {
                        for (var y = RowCount - 1; y >= 0; y--)
                        {
                            if (_numberMap[y, x] == 0) continue;
                            if (temp.Count == 0)
                            {
                                temp.Add(_numberMap[y, x]);
                                continue;
                            }

                            if (_numberMap[y, x] == temp.Last())
                                temp[temp.Count - 1] += _numberMap[y, x];
                            else
                                temp.Add(_numberMap[y, x]);
                        }

                        for (int y = RowCount - 1, j = 0; y >= 0; y--, j++)
                        {
                            _numberMap[y, x] = j < temp.Count ? temp[j] : 0;
                            UpdateBlock(y, x);
                        }

                        temp.Clear();
                    }

                    break;
            }

            if (!AddNewBlock())
                GameOver();
        }
    }
}