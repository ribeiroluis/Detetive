using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Detetive
{
    public partial class Form1 : Form
    {

        Assassino ass = new Assassino();
        List<Lugares> lugar;
        List<Pessoas> Pessoa;
        List<Armas> Armas;
        int soma = 0;
        int clik = 0;
        int SomaCliks = 0;
        int k = 0;
        int contaTimer = 0;

        
        List<Assassino> ListSuspeitos = new List<Assassino>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lugar = new List<Lugares>();
            Lugares l = new Lugares();
            l.Nome = "PRAÇA";
            l.Imagem = Image.FromFile(@"IMG\praca.jpg");
            lugar.Add(l);
            l = new Lugares();
            l.Nome = "RESTAURANTE";
            l.Imagem = Image.FromFile(@"IMG\restaurante.jpg");
            lugar.Add(l);
            l = new Lugares();
            l.Nome = "CEMITERIO";
            l.Imagem = Image.FromFile(@"IMG\cemiterio.jpg");
            lugar.Add(l);
            l = new Lugares();
            l.Nome = "PREFEITURA";
            l.Imagem = Image.FromFile(@"IMG\prefeitura.jpg");
            lugar.Add(l);
            l = new Lugares();
            l.Nome = "ESTACAO DE TREM";
            l.Imagem = Image.FromFile(@"IMG\estacao.jpg");
            lugar.Add(l);
            l = new Lugares();
            l.Nome = "BOATE";
            l.Imagem = Image.FromFile(@"IMG\boate.jpg");
            lugar.Add(l);
            l = new Lugares();
            l.Nome = "HOSPITAL";
            l.Imagem = Image.FromFile(@"IMG\hospital.jpg");
            lugar.Add(l);
            l = new Lugares();
            l.Nome = "MANSAO";
            l.Imagem = Image.FromFile(@"IMG\mansao.jpeg");
            lugar.Add(l);
            l = new Lugares();
            l.Nome = "FLORICULTURA";
            l.Imagem = Image.FromFile(@"IMG\floricultura.jpg");
            lugar.Add(l);
            l = new Lugares();
            l.Nome = "BANCO";
            l.Imagem = Image.FromFile(@"IMG\banco.jpg");
            lugar.Add(l);


            Pessoas p = new Pessoas();
            Pessoa = new List<Pessoas>();
            p.Nome = "COVEIRO";
            p.Imagem = Image.FromFile(@"IMG\coveiro.jpg");
            Pessoa.Add(p);
            p = new Pessoas();
            p.Nome = "CHEFE DE COZINHA";
            p.Imagem = Image.FromFile(@"IMG\cozinheiro.jpg");
            Pessoa.Add(p);
            p = new Pessoas();
            p.Nome = "MEDICO";
            p.Imagem = Image.FromFile(@"IMG\doutor.jpg");
            Pessoa.Add(p);
            p = new Pessoas();
            p.Nome = "DANCARINA";
            p.Imagem = Image.FromFile(@"IMG\dancarina.jpg");
            Pessoa.Add(p);
            p = new Pessoas();
            p.Nome = "POLICIAL";
            p.Imagem = Image.FromFile(@"IMG\policial.jpg");
            Pessoa.Add(p);
            p = new Pessoas();
            p.Nome = "FLORISTA";
            p.Imagem = Image.FromFile(@"IMG\florista.jpg");
            Pessoa.Add(p);
            p = new Pessoas();
            p.Nome = "ADVOGADO";
            p.Imagem = Image.FromFile(@"IMG\advogado.jpg");
            Pessoa.Add(p);
            p = new Pessoas();
            p.Nome = "MORDOMO";
            p.Imagem = Image.FromFile(@"IMG\mordomo.jpg");
            Pessoa.Add(p);

            Armas a = new Armas();
            Armas = new List<Armas>();
            a.Nome = "FACA";
            a.Imagem = Image.FromFile(@"IMG\faca.jpg");
            Armas.Add(a);
            a = new Armas();
            a.Nome = "PORRETE";
            a.Imagem = Image.FromFile(@"IMG\porrete.jpg");
            Armas.Add(a);
            a = new Armas();
            a.Nome = "VENENO";
            a.Imagem = Image.FromFile(@"IMG\veneno.gif");
            Armas.Add(a);
            a = new Armas();
            a.Nome = "ESPINGARDA";
            a.Imagem = Image.FromFile(@"IMG\espingarda.jpg");
            Armas.Add(a);
            a = new Armas();
            a.Nome = "PÁ";
            a.Imagem = Image.FromFile(@"IMG\pa.jpg");
            Armas.Add(a);
            a = new Armas();
            a.Nome = "SOCO INGLES";
            a.Imagem = Image.FromFile(@"IMG\socoingles.jpg");
            Armas.Add(a);
            a = new Armas();
            a.Nome = "PE DE CABRA";
            a.Imagem = Image.FromFile(@"IMG\pedecabra.jpg");
            Armas.Add(a);
            a = new Armas();
            a.Nome = "TESOURA";
            a.Imagem = Image.FromFile(@"IMG\tesoura.jpg");
            Armas.Add(a);

            cbArma.Items.Clear();
            cbLugar.Items.Clear();
            cbPessoa.Items.Clear();

            foreach (var item in lugar)
            {
                cbLugar.Items.Add(item.Nome);
            }
            cbLugar.SelectedIndex = 1;
            foreach (var item in Pessoa)
            {
                cbPessoa.Items.Add(item.Nome);
            }
            cbPessoa.SelectedIndex = 1;

            foreach (var item in Armas)
            {
                cbArma.Items.Add(item.Nome);                
            }
            cbArma.SelectedIndex = 1;





            Random r = new Random();
            int indice = r.Next(0,Pessoa.Count);
            indice = r.Next(0, Pessoa.Count);
            indice = r.Next(0, Pessoa.Count);
            ass.Pessoa = Pessoa[indice];
            Pessoa.RemoveAt(indice);

            indice = r.Next(0, lugar.Count);
            indice = r.Next(0, lugar.Count);
            ass.Lugar = lugar[indice];
            lugar.RemoveAt(indice);

            indice = r.Next(0, Armas.Count);
            indice = r.Next(0, Armas.Count);
            ass.Arma = Armas[indice];
            Armas.RemoveAt(indice);

            Assassino susp;
            foreach (var item in lugar)
            {
                susp = new Assassino();
                susp.Lugar = item;
                ListSuspeitos.Add(susp);             
            }
            foreach (var item in Pessoa)
            {
                susp = new Assassino();
                susp.Pessoa = item;
                ListSuspeitos.Add(susp);
            }
            foreach (var item in Armas)
            {
                susp = new Assassino();
                susp.Arma = item;
                ListSuspeitos.Add(susp);
            }            
        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Novo jogo?","Atenção",MessageBoxButtons.YesNo);
            if (resul == System.Windows.Forms.DialogResult.Yes)
                Form1_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnpalpite.Enabled = false;
            if (ass.Arma.Nome.Equals(cbArma.SelectedItem) &&
                ass.Lugar.Nome.Equals(cbLugar.SelectedItem) &&
                ass.Pessoa.Nome.Equals(cbPessoa.SelectedItem))
            {
                desvendarToolStripMenuItem_Click(sender, e);
                Form1_Load(sender, e);
            }
            else
            {
                soma = 0;
                clik = 0;

                if (SomaCliks % 2 == 0)
                {
                    if (!PesquisaLugar())
                        if (!PesquisaArma())
                            PesquisaPessoa();                 
                }
                else if (SomaCliks % 3 == 0)
                {
                    if (!PesquisaArma())
                        if (!PesquisaLugar())
                            PesquisaPessoa();
                }
                else if (SomaCliks % 5 == 0)
                {
                    if (!PesquisaPessoa())
                        if (!PesquisaLugar())
                            PesquisaArma();
                }
                else
                {
                    if (!PesquisaArma())
                        if (!PesquisaPessoa())
                            PesquisaLugar(); 
                }
            }
        }
        private bool PesquisaLugar()
        {   
            foreach (var item in ListSuspeitos)
            {
                if (item.Lugar != null)
                {
                    if (item.Lugar.Nome.Equals(cbLugar.SelectedItem))
                    {
                        Suspeito s = new Suspeito();
                        s.imgBox.Image = item.Lugar.Imagem;
                        s.lbnome.Text = item.Lugar.Nome;
                        s.ShowDialog();
                        return true;
                    }
                }   
            }
            return false;
        }

        private bool PesquisaPessoa()
        {
            foreach (var item in ListSuspeitos)
            {

                if (item.Pessoa != null)
                {
                    if (item.Pessoa.Nome.Equals(cbPessoa.SelectedItem))
                    {
                        Suspeito s = new Suspeito();
                        s.imgBox.Image = item.Pessoa.Imagem;
                        s.lbnome.Text = item.Pessoa.Nome;
                        s.ShowDialog();
                        return true;
                    }
                }
            }
            return false;

        }

        private bool PesquisaArma()
        {
            foreach (var item in ListSuspeitos)
            {
                if (item.Arma != null)
                {
                    if (item.Arma.Nome.Equals(cbArma.SelectedItem))
                    {
                        Suspeito s = new Suspeito();
                        s.imgBox.Image = item.Arma.Imagem;
                        s.lbnome.Text = item.Arma.Nome;
                        s.ShowDialog();
                        return true;
                    }    
                }
                             
            }
            return false;
        }

        private void desvendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desvendar d = new Desvendar();
            d.imgArma.Image = ass.Arma.Imagem;
            d.lbArma.Text = ass.Arma.Nome;
            d.imgLugar.Image = ass.Lugar.Imagem;
            d.lblugar.Text = ass.Lugar.Nome;
            d.imgPessoa.Image = ass.Pessoa.Imagem;
            d.lbPessoa.Text = ass.Pessoa.Nome;
            d.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SomaCliks = DateTime.Now.Millisecond;
            clik++;
            timer1.Start();
                       
            
        }

        private void regrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "Sorteie por duas vezes clicando no botao sortear\n caso a pontuação seja maior que 7 tente um palpite.\n" +
                "Caso acerta aparecerá o assassino na tela, caso não aparecerá a figura suspeita.\n Para vizualizar o assassino clique em Novo Jogo - Desvendar.";
            MessageBox.Show(text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            if (clik == 1)
            {
                lbSorteio.Text = r.Next(1, 7).ToString();
                contaTimer++;
                k = int.Parse(lbSorteio.Text);
            }
            else
            {
                lbsorteio2.Text = r.Next(1, 7).ToString();
                contaTimer++;
                k = int.Parse(lbsorteio2.Text);
            }

            if (contaTimer == 25)
            {
                soma += k;
                timer1.Stop();                
                contaTimer = 0;
                if (clik > 1)
                {
                    clik = 0;
                    if (soma >= 7)
                    {
                        MessageBox.Show("De um palpite");
                        soma = 0;
                        lbSorteio.Text = "???";
                        lbsorteio2.Text = "???";
                        btnpalpite.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Proximo");
                        lbSorteio.Text = "???";
                        lbsorteio2.Text = "???";
                        soma = 0;
                    }

                }
            }
                

        }        
    }
}
