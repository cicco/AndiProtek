using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;
using System.IO;

namespace AndiProtek
{
    public partial class Form1 : Form
    {
        SQLiteConnection m_dbConnection;
        public Form1()
        {
            InitializeComponent();
            this.txtPath.Text = "D:\\mecdata_d\\clienti\\andimec\\protek\\cnlogger_exported.sqlite";
            this.txtPassword.Text = "cnlogger";
            this.btnClear.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.ClearAll();
            if (!System.IO.File.Exists(this.txtPath.Text))
            {
                return;
            }
            string connectionString = "";
            if ((this.txtPath.Text.Trim().Length > 0) && (this.txtPassword.Text.Trim().Length == 0))
            {
                connectionString = "Data Source=" + this.txtPath.Text + ";Version=3;";
            }
            if ((this.txtPath.Text.Trim().Length > 0) && (this.txtPassword.Text.Trim().Length > 0))
            {
                connectionString = "Data Source=" + this.txtPath.Text + ";Version=3;Password=" + this.txtPassword.Text + ";";
            }
            if (connectionString.Trim().Length > 0)
            {
                m_dbConnection = new SQLiteConnection(connectionString,true);
                
                //
                string sql = "select * from v_LAVORAZIONI_LISTA_AGGREGATA order by lavorazione desc";
                string sql2 = "SELECT name FROM sqlite_master WHERE type='table'";
                //SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                //
                try
                {
                    m_dbConnection.Open();
                    DataSet ds = new DataSet();
                    var da = new SQLiteDataAdapter(sql, m_dbConnection);
                    da.Fill(ds);
                    grid.DataSource = ds.Tables[0].DefaultView;
                    //
                    DataSet ds2 = new DataSet();
                    var da2 = new SQLiteDataAdapter(sql2, m_dbConnection);
                    da2.Fill(ds2);
                    dataGridTables.DataSource = ds2.Tables[0].DefaultView;
                    //
                    this.btnClear.Enabled = true;
                }
                catch (Exception ex)
                {
                    //throw;
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sql = this.txtQuery.Text;
            if (sql.Trim().Length > 0)
            {
                try
                {
                    //m_dbConnection.Open();
                    DataSet ds = new DataSet();
                    var da = new SQLiteDataAdapter(sql, m_dbConnection);
                    da.Fill(ds);
                    dataGridViewQuery.DataSource = ds.Tables[0].DefaultView;
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Sqlite Files|*.sqlite";
            openFileDialog1.Title = "Select a Sqlite File";
            //
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            this.grid.DataSource = null;
            this.dataGridTables.DataSource = null;
            this.dataGridViewQuery.DataSource = null;
        }
    }
}
