using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyingBird
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void Main_KeyDown(object sender, KeyEventArgs e)
		{
			CharacterMove(pbBird1, e);
			HotKey(sender, e);
		}

		void HotKey(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.P:
					PauseGame();
					break;
				case Keys.Space:
					ResumeGame();
					break;
				case Keys.R:
					ResetGame();
					break;
			}
		}

		void ResetGame()
		{
			PauseGame();

			for (int i = 0; i < rocket.Count; i++)
			{
				rocket[i].Dispose();
			}

			rocket = new List<PictureBox>();

			ResumeGame();
		}

		/// <summary>
		/// Di chuyển character dựa vào phím điều hướng
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void CharacterMove(object sender, KeyEventArgs e)
		{
			PictureBox bird = sender as PictureBox;
			Point newPoint = new Point(bird.Location.X, bird.Location.Y);

			bool isMove = false;

			switch (e.KeyCode)
			{
				case Keys.Right:
					if (newPoint.X + Constain.PlayerSpeed +
						bird.Size.Width < this.Size.Width - 20)
					{
						newPoint.X += Constain.PlayerSpeed;
						isMove = true;
					}
					break;
				case Keys.Left:
					if (newPoint.X - Constain.PlayerSpeed > 0)
					{
						newPoint.X -= Constain.PlayerSpeed;
						isMove = true;
					}
					break;
				case Keys.Up:
					if (newPoint.Y - Constain.PlayerSpeed > 0)
					{
						newPoint.Y -= Constain.PlayerSpeed;
						isMove = true;
					}
					break;
				case Keys.Down:
					if (newPoint.Y + Constain.PlayerSpeed +
						bird.Size.Height + Constain.TitleBarHeight < this.Size.Height)
					{
						newPoint.Y += Constain.PlayerSpeed;
						isMove = true;
					}
					break;
			}

			if (isMove)
			{
				bird.Location = newPoint;
			}
		}

		bool isIdle = false;
		/// <summary>
		/// Amination đập cánh
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PlayerAnimation_Tick(object sender, EventArgs e)
		{
			if (isIdle)
			{
				pbBird1.Image = Properties.Resources.Bird2;
			}
			else
			{
				pbBird1.Image = Properties.Resources.Bird;
			}
			isIdle = !isIdle;
		}

		List<PictureBox> rocket = new List<PictureBox>();
		/// <summary>
		/// Tạo ngẫu nhiên 1 rocket
		/// </summary>
		void SpawnRocket()
		{
			PictureBox newRocket = new PictureBox();
			newRocket.Image = Properties.Resources.Rocket;
			newRocket.SizeMode = PictureBoxSizeMode.StretchImage;
			newRocket.BackColor = Color.Transparent;
			newRocket.Location = new Point(0, random.Next(0, 
				this.Size.Height - Constain.TitleBarHeight - newRocket.Size.Height));
			rocket.Add(newRocket);
			this.Controls.Add(newRocket);
		}

		private void RocketMoverment_Tick(object sender, EventArgs e)
		{
			foreach (PictureBox item in rocket)
			{
				item.Location = new Point(item.Location.X +
					Constain.RocketSpeed, item.Location.Y);
				if (IsTrigger(item, pbBird1) || IsTrigger(pbBird1, item))
				{
					PauseGame();
					MessageBox.Show("Game over!" + Environment.NewLine + "Your score is: " + lbScore.Text);
					ResetGame();
				}
			}

			for (int i = 0; i < rocket.Count; i++)
			{
				if (rocket[i].Location.X >= this.Size.Width)
				{
					// Hủy khỏi form
					rocket[i].Dispose();

					rocket.Remove(rocket[i]);
				}	
			}
		}

		Random random = new Random();
		private void AutoSpawn_Tick(object sender, EventArgs e)
		{
			SpawnRocket();
			(sender as Timer).Interval = random.Next(Constain.MinimumTimeSpawnRocket,
				Constain.MaximunTimeSpawnRocket + 1) * 1000;
		}

		bool IsTrigger(Control a, Control b)
		{
			if ((a.Location.X <= b.Location.X && a.Location.X + a.Size.Width > b.Location.X)
				&& (a.Location.Y <= b.Location.Y && a.Location.Y + a.Size.Height > b.Location.Y)
				|| ((a.Location.X + a.Size.Width + a.Size.Height <= b.Location.X + b.Size.Width + b.Size.Height && a.Location.X + a.Size.Width + a.Size.Height > b.Location.X + b.Size.Width)
				&& (a.Location.Y + a.Size.Width + a.Size.Height <= b.Location.Y + b.Size.Width + b.Size.Height && a.Location.Y + a.Size.Width + a.Size.Height > b.Location.Y + b.Size.Width)))
				return true;
			return false;
		}

		void PauseGame()
		{
			PlayerAnimation.Stop();
			RocketMoverment.Stop();
			AutoSpawn.Stop();
		}

		void ResumeGame()
		{
			lbScore.Text = "0";
			PlayerAnimation.Start();
			RocketMoverment.Start();
			AutoSpawn.Start();
		}

		private void Point_Tick(object sender, EventArgs e)
		{
			lbScore.Text = (int.Parse(lbScore.Text) + 1).ToString();
		}
	}
}
