using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyGame
{
    public partial class score1 : Form

    {
        int pipespeed = 5;
        int gravity = 7;
        //int scoreLabel = 10;
        int score = 10;
        private PictureBox pipedown;
        private PictureBox pipeup;

        private Label scoreLabel;

        public score1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // Movimento do pássaro e dos obstáculos
            bird.Top += gravity;
            pipeDow.Left -= pipespeed;
            pipeU.Left -= pipespeed;

            // Atualização do texto de pontuação
            scoreLbl.Text = "Score: " + score.ToString();

            // Reposicionamento dos pipes e incremento da pontuação
            if (pipeDow.Left < -150)
            {
                pipeDow.Left = 800;
                score++;
            }

            if (pipeU.Left < -150)
            {
                pipeU.Left = 950;
                score++;
            }

            // Detecção de colisão
            if (bird.Bounds.IntersectsWith(pipeDow.Bounds) || bird.Bounds.IntersectsWith(pipeU.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                EndGame();  
            }

            // Limite da tela: se o pássaro sair para fora do topo
            if (bird.Top < -25)
            {
                EndGame();
            }
            }

        private void EndGame()
        {
            gametimer.Stop(); // Para o timer do jogo
            scoreLbl.Text += "  Game Over!";

            // Exibe uma mensagem perguntando se o jogador quer tentar novamente
            DialogResult dialogResult = MessageBox.Show("Você perdeu! Deseja jogar novamente?", "Game Over", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                ResetGame(); // Reinicia o jogo se o jogador escolher "Sim"
            }
            else
            {
                this.Close(); // Fecha o jogo se o jogador escolher "Não"
            }
        }

        private void ResetGame()
        {
            // Reinicia a posição do pássaro
            bird.Top = 200;

            // Reinicia a posição dos pipes
            pipeDow.Left = 800;
            pipeU.Left = 950;

            // Reinicia a pontuação
            score = 0;
            scoreLbl.Text = "Score: 0";

            // Reinicia o timer do jogo
            gametimer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)

            {
                gravity = -7;
            }

        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 7;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}