using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace WindowsFormsShip
{
    public partial class FormPier : Form
    {
        MultiLevelPier pier;
        FormShipConfig form;
        private const int countLevel = 5;
        private Logger logger;
        public FormPier()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            pier = new MultiLevelPier(countLevel, pictureBoxPier.Width, pictureBoxPier.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxPier.Width, pictureBoxPier.Height);
                Graphics gr = Graphics.FromImage(bmp);
                pier[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxPier.Image = bmp;
            }
        }
        private void buttonTake_Click(object sender, EventArgs e)
        {
            if ((listBoxLevels.SelectedIndex > -1) && 
                (maskedTextBox.Text != ""))
            {
                try
                {
                    var ship = pier[listBoxLevels.SelectedIndex] -
                        Convert.ToInt32(maskedTextBox.Text);                    
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    ship.SetPosition(100, 50, pictureBoxTake.Width, pictureBoxTake.Height);
                    ship.DrawShip(gr);
                    pictureBoxTake.Image = bmp;
                    logger.Info("Изъят корабль " + ship.ToString() + " с места " +
                        maskedTextBox.Text);
                    Draw();                    
                }
                catch(PierNotFoundException ex)
                {
                    logger.Error(ex.Message, "Не найдено");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                    pictureBoxTake.Image = bmp;
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message, "Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            form = new FormShipConfig();
            form.AddEvent(AddShip);
            form.Show();
        }
        private void AddShip(ITransport ship)
        {
            if (ship != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = pier[listBoxLevels.SelectedIndex] + ship;
                    logger.Info("Добавлен корабль " + ship.ToString() + " на место " + place);
                    Draw();
                }
                catch(PierOverflowException ex)
                {
                    logger.Error(ex.Message, "Переполнение");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (PierAlreadyHaveException ex)
                {
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message, "Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    pier.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch(Exception ex)
                {
                    logger.Error(ex.Message, "Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    pier.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (PierOccupiedPlaceException ex)
                {
                    logger.Error(ex.Message, "Занятое место");
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    logger.Error(ex.Message, "Неизвестная ошибка при загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            pier.Sort();
            Draw();
            logger.Info("Сортировка уровней");
        }
    }
}

