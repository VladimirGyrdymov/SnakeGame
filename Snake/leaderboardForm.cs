using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Snake
{
    public partial class leaderboardForm : Form
    {
        public leaderboardForm()
        {
            InitializeComponent();
        }

        BindingSource bindingSource1 = new BindingSource();

        private void LeaderboardForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = ВЛАДИМИР-ПК\SQLEXPRESS; Initial Catalog = SnakeBase; Trusted_Connection = True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("select nickname, score from leaderboard order by score desc", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            bindingSource1.DataSource = dt;

            conn.Close();

            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            dataGridView.DataSource = bindingSource1;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView[0, i].Value = (i + 1);
            }
        }
    }
}
